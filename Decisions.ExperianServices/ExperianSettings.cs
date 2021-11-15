using DecisionsFramework.Data.ORMapper;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.Design.Properties.Attributes;
using DecisionsFramework.ServiceLayer;
using DecisionsFramework.ServiceLayer.Actions;
using DecisionsFramework.ServiceLayer.Actions.Common;
using DecisionsFramework.ServiceLayer.Services.Accounts;
using DecisionsFramework.ServiceLayer.Services.Administration;
using DecisionsFramework.ServiceLayer.Services.Folder;
using DecisionsFramework.ServiceLayer.Utilities;

namespace Decisions.ExperianServices
{
    public class ExperianSettings : AbstractModuleSettings, IInitializable
    {
        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [ORMField]
        [PropertyClassification(0, "Experian API Connection URL", "Experian")]
        public string ExperianCoreApiUrl { get; set; }

        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [ORMField]
        [PropertyClassification(1, "Client Reference ID", "Experian")]
        public string ExperianClientReferenceId { get; set; }

        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [ORMField]
        [PropertyClassification(2, "API Username", "Experian")]
        public string ExperianUsername { get; set; }

        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [ORMField]
        [PropertyClassification(3, "API Password", "Experian")]
        [PasswordText]
        public string ExperianPassword { get; set; }

        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [ORMField]
        [PropertyClassification(4, "API Client ID", "Experian")]
        public string ExperianClientId { get; set; }

        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [ORMField]
        [PropertyClassification(5, "API Client Secret", "Experian")]
        public string ExperianClientSecret { get; set; }

        [BooleanPropertyHidden(nameof(EnableExperian), false)]
        [WritableValue]
        [PropertyClassification(6, "Enable Clarity", "Experian")]
        public bool EnableClarity { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [ORMField]
        [PropertyClassification(7, "API Connection URL", "Clarity")]
        public string ClarityApiUrl { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [ORMField]
        [PropertyClassification(8, "Client Reference ID", "Clarity")]
        public string ClarityClientReferenceId { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [ORMField]
        [PropertyClassification(9, "API Username", "Clarity")]
        public string ClarityUsername { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [ORMField]
        [PropertyClassification(10, "API Password", "Clarity")]
        [PasswordText]
        public string ClarityPassword { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [ORMField]
        [PropertyClassification(11, "API Client ID", "Clarity")]
        public string ClarityClientId { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [ORMField]
        [PropertyClassification(12, "API Client Secret", "Clarity")]
        public string ClarityClientSecret { get; set; }

        [BooleanPropertyHidden(nameof(EnableClarity), false)]
        [WritableValue]
        [PropertyClassification(13, "Enable Experian", "Clarity")]
        public bool EnableExperian { get; set; } = true;

        public void Initialize()
        {
            // Read the Settings here
            ModuleSettingsAccessor<ExperianSettings>.GetSettings();
        }

        public override BaseActionType[] GetActions(AbstractUserContext userContext, EntityActionType[] types)
        {
            Account userAccount = userContext.GetAccount();

            FolderPermission permission = FolderService.Instance.GetAccountEffectivePermission(
                new SystemUserContext(), this.EntityFolderID, userAccount.AccountID);

            bool canAdministrate = FolderPermission.CanAdministrate == (FolderPermission.CanAdministrate & permission) ||
                                   userAccount.GetUserRights<PortalAdministratorModuleRight>() != null ||
                                   userAccount.IsAdministrator();

            if (canAdministrate)
                return new BaseActionType[]
                {
                    new EditEntityAction(GetType(), "Edit", null),
                };

            return new BaseActionType[0];
        }
    }
}
