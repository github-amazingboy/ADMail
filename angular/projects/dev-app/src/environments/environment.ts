import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'ADMail',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44389/',
    redirectUri: baseUrl,
    clientId: 'ADMail_App',
    responseType: 'code',
    scope: 'offline_access ADMail',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44389',
      rootNamespace: 'ADMail',
    },
    ADMail: {
      url: 'https://localhost:44326',
      rootNamespace: 'ADMail',
    },
  },
} as Environment;
