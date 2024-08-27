import { InjectionToken, Provider } from "@angular/core";

//union types
export type TaskStatus = 'OPEN' | 'IN_PROGRESS' | 'DONE';

type TaskStatusOptions = 
{
 value:'open' | 'in_progress' | 'done';
 status:TaskStatus;
 text:string;
}[];

//to inject non class for 'task-item' component
export const TASK_STATUS_OPTIONS = new InjectionToken<TaskStatusOptions>("TASK_STATUS_OPTIONS");

export const taskStatusOptions : TaskStatusOptions = [
  {
    value:'open',
    status:'OPEN',
    text:'open'
  },
  {
    value:'in_progress',
    status:'IN_PROGRESS',
    text:'In_Progress'
  },
  {
    value:'done',
    status:'DONE',
    text:'Completed'
  }
];

//provide the InjectionToken Instance, and value of variable for type that we target
export const taskStatusOptionsProvider :Provider = {provide:TASK_STATUS_OPTIONS,useValue:taskStatusOptions};

export interface Task {
  id: string;
  title: string;
  description: string;
  status: TaskStatus;
}
