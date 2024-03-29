using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DecisionsFramework;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Interface;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.Design.Properties.Attributes;
using DecisionsFramework.ProjectConversion.DMN;
using DecisionsFramework.ServiceLayer;

namespace Decisions.ExperianServices
{
    [Writable]
    public abstract class AbstractExperianStep : IFlowAwareStep, ISyncStep, INotifyPropertyChanged, IValidationSource
    {
        protected static readonly Log Log = new(ExperianConstants.LogCat);
        
        protected const string RequestText = "Request";
        protected const string CreditReportResponseText = "CreditReportResponse";
        protected const string PreQualificationResponseText = "PreQualificationReportResponse";
        protected const string VerifyResponseText = "VerifyResponse";

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
                OnPropertyChanged(nameof(UserName));
                OnPropertyChanged(nameof(Password));
                OnPropertyChanged(nameof(ClientId));
                OnPropertyChanged(nameof(ClientSecret));
                OnPropertyChanged(nameof(ClientReferenceId));
                OnPropertyChanged(nameof(InputData));
            }
        }

        [WritableValue] 
        private string userName;
        
        [PropertyHiddenByValue(nameof(OverrideCredentials), false, true)]
        [PropertyClassification(1, "Experian Username", "Settings")]
        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged();
            }
        }

        [WritableValue] 
        private string password;
        
        [PasswordText]
        [PropertyHiddenByValue(nameof(OverrideCredentials), false, true)]
        [PropertyClassification(2, "Experian Password", "Settings")]
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(); 
            }
        }

        [WritableValue] 
        private string clientId;
        
        [PropertyHiddenByValue(nameof(OverrideCredentials), false, true)]
        [PropertyClassification(3, "Experian Client ID", "Settings")]
        public string ClientId
        {
            get => clientId;
            set
            {
                clientId = value;
                OnPropertyChanged();
            }
        }

        [WritableValue] 
        private string clientSecret;
        
        [PropertyHiddenByValue(nameof(OverrideCredentials), false, true)]
        [PropertyClassification(4, "Experian Client Secret", "Settings")]
        public string ClientSecret
        {
            get => clientSecret;
            set
            {
                clientSecret = value;
                OnPropertyChanged();
            }
        }

        [WritableValue] 
        private string clientReferenceId;
        
        [PropertyHiddenByValue(nameof(OverrideCredentials), false, true)]
        [PropertyClassification(5, "Experian Client Reference ID", "Settings")]
        public string ClientReferenceId
        {
            get => clientReferenceId;
            set
            {
                clientReferenceId = value;
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public abstract ResultData Run(StepStartData data);
        
        public abstract OutcomeScenarioData[] OutcomeScenarios { get; }

        public virtual ValidationIssue[] GetValidationIssues()
        {
            List<ValidationIssue> issues = new List<ValidationIssue>();
            
            if (_overrideCredentials && 
                (string.IsNullOrEmpty(UserName) || 
                string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(ClientReferenceId)))
            {
                issues.Add(new ValidationIssue("If Credentials are overridden, Username, Password, and " +
                                               "Client Reference ID must be specified in the step properties."));
            }
            else if (!_overrideCredentials && 
                     (string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianUsername) || 
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianPassword) ||
                     string.IsNullOrEmpty(ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId)))
            {
                issues.Add(new ValidationIssue("If Credentials are not overridden, Username, Password, and " +
                                               "Client Reference ID must be specified in the Experian Settings."));
            }

            return issues.ToArray();
        }
    }
}