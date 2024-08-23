import { InjectionToken } from "@angular/core";

//union types
export type TaskStatus = 'OPEN' | 'IN_PROGRESS' | 'DONE';

//to inject non class for 'task-item' component
export const TASK_STATUS_OPTIONS = new InjectionToken<TaskStatusOptions>("TASK_STATUS_OPTIONS");

type TaskStatusOptions = 
{
 value:'open' | 'in_progress' | 'done';
 status:TaskStatus;
 text:string;
}[];

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

export interface Task {
  id: string;
  title: string;
  description: string;
  status: TaskStatus;
}
