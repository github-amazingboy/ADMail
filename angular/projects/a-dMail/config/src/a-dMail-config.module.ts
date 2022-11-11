import { ModuleWithProviders, NgModule } from '@angular/core';
import { AD_MAIL_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class ADMailConfigModule {
  static forRoot(): ModuleWithProviders<ADMailConfigModule> {
    return {
      ngModule: ADMailConfigModule,
      providers: [AD_MAIL_ROUTE_PROVIDERS],
    };
  }
}
