import { EntityState, EntityAdapter, createEntityAdapter } from '@ngrx/entity';
import { ModelClass } from 'modelClassFile.model.ts';
import { ModelClassActions, ModelClassActionTypes } from './modelClass.actions';

export interface ModelClassState extends EntityState<ModelClass> {
  // additional entities state properties
}

export const adapter: EntityAdapter<ModelClass> = createEntityAdapter<ModelClass>();

export const initialModelClassState: ModelClassState = adapter.getInitialState({
  // additional entity state properties
});

export function reducer(
  state = initialModelClassState,
  action: ModelClassActions
): ModelClassState {
  switch (action.type) {
    case ModelClassActionTypes.AddModelClass: {
      return adapter.addOne(action.payload.ModelClass, state);
    }

    case ModelClassActionTypes.UpsertModelClass: {
      return adapter.upsertOne(action.payload.ModelClass, state);
    }

    case ModelClassActionTypes.AddModelClasss: {
      return adapter.addMany(action.payload.ModelClasss, state);
    }

    case ModelClassActionTypes.UpsertModelClasss: {
      return adapter.upsertMany(action.payload.ModelClasss, state);
    }

    case ModelClassActionTypes.UpdateModelClass: {
      return adapter.updateOne(action.payload.ModelClass, state);
    }

    case ModelClassActionTypes.UpdateModelClasss: {
      return adapter.updateMany(action.payload.ModelClasss, state);
    }

    case ModelClassActionTypes.DeleteModelClass: {
      return adapter.removeOne(action.payload.id, state);
    }

    case ModelClassActionTypes.DeleteModelClasss: {
      return adapter.removeMany(action.payload.ids, state);
    }

    case ModelClassActionTypes.LoadModelClasss: {
      return adapter.addAll(action.payload.ModelClasss, state);
    }

    case ModelClassActionTypes.ClearModelClasss: {
      return adapter.removeAll(state);
    }

    default: {
      return state;
    }
  }
}

export const {
  selectIds,
  selectEntities,
  selectAll,
  selectTotal,
} = adapter.getSelectors();
