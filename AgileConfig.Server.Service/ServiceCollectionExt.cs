﻿using AgileConfig.Server.IService;
using Microsoft.Extensions.DependencyInjection;

namespace AgileConfig.Server.Service
{
    public static class ServiceCollectionExt
    {
        public static void AddBusinessServices(this IServiceCollection sc)
        {
            sc.AddScoped<IAppService, AppService>();
            sc.AddScoped<IConfigService, ConfigService>();
            sc.AddScoped<IServerNodeService, ServerNodeService>();
            sc.AddScoped<IModifyLogService, ModifyLogService>();
            sc.AddScoped<ISettingService, SettingService>();
            sc.AddScoped<IRemoteServerNodeActionProxy, RemoteServerNodeProxy>();
            sc.AddScoped<IRemoteServerNodeManager, RemoteServerNodeManager>();
            sc.AddScoped<ISysLogService, SysLogService>();
        }
    }
}
