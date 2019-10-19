import { createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromModelClass from './modelClass.reducer';


export const modelClassState = createFeatureSelector('modelClass');

export const modelClassAll = createSelector(
    modelClassState,
    fromModelClass.selectAll
)

export const modelClassById = (id: string) => createSelector(
    modelClassAll,
    state => state.find(x => x.id === id)
);
