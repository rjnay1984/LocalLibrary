import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { Amplify } from 'aws-amplify';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

Amplify.configure({
  Auth: {
    userPoolId: 'us-east-2_HgpMvqAUg',
    region: 'us-east-2',
    userPoolWebClientId: '5t49rl7eef87cmtglek4qfvdul',
  },
});

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic()
  .bootstrapModule(AppModule)
  .catch((err) => console.error(err));
