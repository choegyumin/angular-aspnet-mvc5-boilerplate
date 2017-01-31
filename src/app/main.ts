/// <reference path="../Scripts/TypeLite.Net4.d.ts" />

import { platformBrowser } from '@angular/platform-browser';
import { AppModuleNgFactory } from '../build/app/app.module.ngfactory';

platformBrowser().bootstrapModuleFactory(AppModuleNgFactory);
