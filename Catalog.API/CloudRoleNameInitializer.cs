namespace Microsoft.eShopOnContainers.Services.Catalog.API
{
    using System;
    using Microsoft.ApplicationInsights.Channel;
    using Microsoft.ApplicationInsights.DataContracts;
    using Microsoft.ApplicationInsights.Extensibility;
    public class CloudRoleNameInitializer : ITelemetryInitializer
    {
        private readonly string roleName;

        public CloudRoleNameInitializer(string roleName)
        {
            this.roleName = roleName ?? throw new ArgumentNullException(nameof(roleName));
        }

        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Cloud.RoleName = this.roleName;
        }
    }
}