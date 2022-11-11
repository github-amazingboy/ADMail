import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ADMailComponent } from './components/a-dMail.component';
import { ADMailRoutingModule } from './a-dMail-routing.module';

@NgModule({
  declarations: [ADMailComponent],
  imports: [CoreModule, ThemeSharedModule, ADMailRoutingModule],
  exports: [ADMailComponent],
})
export class ADMailModule {
  static forChild(): ModuleWithProviders<ADMailModule> {
    return {
      ngModule: ADMailModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<ADMailModule> {
    return new LazyModuleFactory(ADMailModule.forChild());
  }
}
