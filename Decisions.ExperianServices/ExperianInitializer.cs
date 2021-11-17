using System.Data;
using DecisionsFramework.Data.ORMapper;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    public class ExperianInitializer : IInitializable
    {
        public void Initialize()
        {
            /*
           * The steps have been moved and since they're in a module we want to do the old step category cleanup
           * in the module itself vs. in the core code.
           */
            CompositeSelectStatement compositeSelectStatement = new CompositeSelectStatement(new 
                CompositeSelectStatement.TableDefinition("element_registration"));
            compositeSelectStatement.PrimaryTable.AllFields = true;

            compositeSelectStatement.JoinList.Add(
                new CompositeSelectStatement.JoinDefinition(
                    CompositeSelectStatement.JoinType.InnerJoin,
                    new CompositeSelectStatement.TableDefinition("entity_folder"),
                    new AndWhereSet(new WhereCondition[]
                    {
                        new FieldToFieldWhereCondition(
                            "element_registration.entity_folder_id",
                            "entity_folder.folder_id",
                            QueryMatchType.Equals)
                    })
                ));

            compositeSelectStatement.WhereConditions.WhereConditions.Add(
                new AndWhereSet(new WhereCondition[]
                {
                    new FieldWhereCondition(
                        "element_registration.entity_name",
                        QueryMatchType.EqualsWithoutCase,
                        "Experian Consumer Credit Profile"),
                    new FieldWhereCondition(
                        "entity_folder.full_path",
                        QueryMatchType.EqualsWithoutCase,
                        "System/Designers/Catalog/Credit Profile/Experian Steps")
                }));

          
            DynamicORM orm = new DynamicORM();

            DataSet results = orm.RunQuery(compositeSelectStatement);

            /*
             * We only need to do this if the old step categories are there.
             */
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                string sqlQuery = @"
                                IF EXISTS (SELECT 1 FROM sys.triggers  WHERE Name = 'Delete_element_registration')
                                    DISABLE TRIGGER Delete_element_registration ON element_registration;  

                                DELETE dbo.element_registration
                                FROM dbo.element_registration
                                INNER JOIN dbo.entity_folder ON element_registration.entity_folder_id = entity_folder.folder_id
                                WHERE element_registration.entity_name = 'Experian Consumer Credit Profile'
                                AND entity_folder.full_path = 'System/Designers/Catalog/Credit Profile/Experian Steps';

                                IF EXISTS (SELECT 1 FROM sys.triggers  WHERE Name = 'Delete_element_registration')
                                   ENABLE TRIGGER Delete_element_registration ON element_registration; 
                                   
                                /* As we disabled the Trigger when Deleting the Element Registrations, we need to manually remove these items from the Entity Header Data */   
                                IF EXISTS (SELECT 1 FROM sys.triggers  WHERE Name = 'entity_header_data_delete_trigger')
                                   DISABLE TRIGGER entity_header_data_delete_trigger ON entity_header_data;  

                                delete from entity_header_data where id in (
                                select ehd.id from entity_header_data ehd left join element_registration er 
                                on ehd.id = er.component_registration_id
                                where er.component_registration_id is null and entity_type_name = 'DecisionsFramework.ServiceLayer.Services.ConfigurationStorage.ElementRegistration')

                                IF EXISTS (SELECT 1 FROM sys.triggers  WHERE Name = 'entity_header_data_delete_trigger')
                                   Enable TRIGGER entity_header_data_delete_trigger ON entity_header_data;";

                orm.RunQuery(sqlQuery);
            }
        }
    }
}