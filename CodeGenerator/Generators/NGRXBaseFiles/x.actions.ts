import { Action } from '@ngrx/store';
import { Update } from '@ngrx/entity';
import { ModelClass } from 'modelClassFile.model.ts';

export enum ModelClassActionTypes { 
    LoadModelClasss = '[ModelClass] Load ModelClasss',
    AddModelClass = '[ModelClass] Add ModelClass',
    UpsertModelClass = '[ModelClass] Upsert ModelClass',
    AddModelClasss = '[ModelClass] Add ModelClasss',
    UpsertModelClasss = '[ModelClass] Upsert ModelClasss',
    UpdateModelClass = '[ModelClass] Update ModelClass',
    UpdateModelClasss = '[ModelClass] Update ModelClasss',
    DeleteModelClass = '[ModelClass] Delete ModelClass',
    DeleteModelClasss = '[ModelClass] Delete ModelClasss',
    ClearModelClasss = '[ModelClass] Clear ModelClasss'
}

export class LoadModelClasss implements Action {
  readonly type = ModelClassActionTypes.LoadModelClasss;

  constructor(public payload: { ModelClasss: ModelClass[] }) {}
}

export class AddModelClass implements Action {
  readonly type = ModelClassActionTypes.AddModelClass;

  constructor(public payload: { ModelClass: ModelClass }) {}
}

export class UpsertModelClass implements Action {
  readonly type = ModelClassActionTypes.UpsertModelClass;

  constructor(public payload: { ModelClass: ModelClass }) {}
}

export class AddModelClasss implements Action {
  readonly type = ModelClassActionTypes.AddModelClasss;

  constructor(public payload: { ModelClasss: ModelClass[] }) {}
}

export class UpsertModelClasss implements Action {
  readonly type = ModelClassActionTypes.UpsertModelClasss;

  constructor(public payload: { ModelClasss: ModelClass[] }) {}
}

export class UpdateModelClass implements Action {
  readonly type = ModelClassActionTypes.UpdateModelClass;

  constructor(public payload: { ModelClass: Update<ModelClass> }) {}
}

export class UpdateModelClasss implements Action {
  readonly type = ModelClassActionTypes.UpdateModelClasss;

  constructor(public payload: { ModelClasss: Update<ModelClass>[] }) {}
}

export class DeleteModelClass implements Action {
  readonly type = ModelClassActionTypes.DeleteModelClass;

  constructor(public payload: { id: string }) {}
}

export class DeleteModelClasss implements Action {
  readonly type = ModelClassActionTypes.DeleteModelClasss;

  constructor(public payload: { ids: string[] }) {}
}

export class ClearModelClasss implements Action {
  readonly type = ModelClassActionTypes.ClearModelClasss;
}

export type ModelClassActions =
 | LoadModelClasss
 | AddModelClass
 | UpsertModelClass
 | AddModelClasss
 | UpsertModelClasss
 | UpdateModelClass
 | UpdateModelClasss
 | DeleteModelClass
 | DeleteModelClasss
 | ClearModelClasss;
