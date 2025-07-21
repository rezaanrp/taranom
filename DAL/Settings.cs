namespace DAL.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        [global::System.Configuration.UserScopedSettingAttribute()]
        public string ConnectionString
        {
            get { return (string)this["ConnectionString"]; }
            set { this["ConnectionString"] = value; }
        }
        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
            this.PropertyChanged +=
                 new System.ComponentModel.PropertyChangedEventHandler(this.Settings_PropertyChanged);
            this.SettingsLoaded +=
              new System.Configuration.SettingsLoadedEventHandler(this.Settings_SettingsLoaded);
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.

        }
        private void Settings_PropertyChanged(System.Object sender,
         System.ComponentModel.PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == "ConnectionString")
            //{
            //    this["Original_ConnectionString"] = this.ConnectionString;
            //}
        }

        private void Settings_SettingsLoaded(System.Object sender,
                System.Configuration.SettingsLoadedEventArgs e)
        {
            // Advanced codes for post loading process...
        }
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }
    }
}
