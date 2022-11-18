using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DecisionsFramework;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Interface;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    [Writable]
    public abstract class AbstractExperianStep : IFlowAwareStep, ISyncStep, IDataConsumer, INotifyPropertyChanged, IValidationSource
    {
        protected static readonly Log Log = new(ExperianConstants.LogCat);
        
        protected const string RequestText = "Request";
        protected const string ResponseText = "Response";
        private const string ClientReferenceIdText = "Client Reference ID";
        private const string ApiUsernameText = "API Username";
        private const string ApiPasswordText = "API Password";
        private const string ClientIdText = "Client ID";
        private const string ClientSecretText = "Client Secret";

        protected string UserName = "";
        protected string Password = "";
        protected string ClientId = "";
        protected string ClientSecret = "";
        protected string ClientReferenceId = ""; 
        
        [PropertyHidden] 
        public Flow Flow { get; set; }
        
        [PropertyHidden] 
        public FlowStep FlowStep { get; set; }

        [WritableValue]
        private bool _overrideCredentials;

        [PropertyClassification(0, "Override Credentials", "Settings")]
        public bool OverrideCredentials
        {
            get => _overrideCredentials;

            set
            {
                _overrideCredentials = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(InputData));
            }
        }
        
        public virtual DataDescription[] InputData
        {
            get
            {
                List<DataDescription> inputs = new List<DataDescription>();

                if (_overrideCredentials)
                {
                    inputs.Add(new DataDescription(typeof(string), ClientReferenceIdText));
                    inputs.Add(new DataDescription(typeof(string), ApiUsernameText));
                    inputs.Add(new DataDescription(typeof(string), ApiPasswordText));
                    inputs.Add(new DataDescription(typeof(string), ClientIdText));
                    inputs.Add(new DataDescription(typeof(string), ClientSecretText));
                }

                return inputs.ToArray();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public abstract ResultData Run(StepStartData data);
        
        public abstract OutcomeScenarioData[] OutcomeScenarios { get; }

        protected void SetUpInputVariables(StepStartData data)
        {
            if (OverrideCredentials)
            {
                if (data.ContainsKey(ApiUsernameText) && data[ApiUsernameText] != null)
                {
                    UserName = data[ApiUsernameText] as string;
                }
                
                if (data.ContainsKey(ApiPasswordText) && data[ApiPasswordText] != null)
                {
                    Password = data[ApiPasswordText] as string;
                }
                
                if (data.ContainsKey(ClientIdText) && data[ClientIdText] != null)
                {
                    ClientId = data[ClientIdText] as string;
                }
                
                if (data.ContainsKey(ClientSecretText) && data[ClientSecretText] != null)
                {
                    ClientSecret = data[ClientSecretText] as string;
                }
                
                if (data.ContainsKey(ClientReferenceIdText) && data[ClientReferenceIdText] != null)
                {
                    ClientReferenceId = data[ClientReferenceIdText] as string;
                }
            }
        }

        public virtual ValidationIssue[] GetValidationIssues()
        {
            List<ValidationIssue> issues = new List<ValidationIssue>();
            
            if (_overrideCredentials && 
                string.IsNullOrEmpty(UserName) || 
                string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(ClientReferenceId))
            {
                issues.Add(new ValidationIssue("If Credentials are overridden, Username, Password, and Client Reference ID must be specified in the step properties."));
            }
            else if (!_overrideCredentials && 
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianUsername) || 
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianPassword) ||
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Username, Password, and Client Reference ID must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}