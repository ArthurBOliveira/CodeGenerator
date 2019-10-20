import { Injectable } from '@angular/core';
import { Actions, Effect, ofType } from '@ngrx/effects';
import { Store } from '@ngrx/store';
import { ModelClassService } from './modelClass.service';
import { ModelClassState } from './modelClass.reducer';

@Injectable()
export class ModelClassEffects {

  constructor(private actsions$: Actions,
    private modelClassService: ModelClassService,
    private modelClassStore: Store<ModelClassState>) {}

}
