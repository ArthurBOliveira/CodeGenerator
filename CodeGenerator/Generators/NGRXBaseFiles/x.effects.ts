import { Injectable } from '@angular/core';
import { Actions, Effect, ofType } from '@ngrx/effects';
import { ModelClassService } from './modelClass.service';
import { Store } from '@ngrx/store';
import { withLatestFrom, filter, mergeMap, map, tap, take } from 'rxjs/operators';
import { ModelClassState } from './modelClass.reducer';

@Injectable()
export class ModelClassEffects {

  constructor(private actsions$: Actions,
    private modelClassService: ModelClassService,
    private modelClassStore: Store<ModelClassState>) {}

}
