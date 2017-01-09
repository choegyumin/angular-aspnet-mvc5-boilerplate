import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeContainer, ErrorContainer } from './containers/index';

const routes: Routes = [
	{ path: '', component: HomeContainer },
	{ path: 'index', redirectTo: '' },
	{ path: 'home', redirectTo: '' },
	{ path: '**', component: ErrorContainer }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule { }
