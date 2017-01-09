import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { TodoService } from '../../services/index';

@Component({
	moduleId: module.id,
	selector: 'component-todo',
	templateUrl: 'todo.component.html'
})
export class TodoComponent {
	model: any = {};
	todoes: src.Models.Todo[];

	constructor(
		private router: Router,
		private todoService: TodoService
	) {
		this.model = {};
		this.todoes = [];
	}

	private loadAllTodoes() {
		this.todoService.readAll().subscribe(
			todoes => {
				this.todoes = todoes;
			});
	}

	ngOnInit() {
		this.loadAllTodoes();
	}

	addTodo(formData: any) {
		formData.hasValid = formData.valid;
		if (!formData.valid) return false;

		formData.loading = true;

		let todo: src.Models.Todo = formData.value;
		todo.completed = false;

		this.todoService.create(todo).subscribe(
			data => {
				this.loadAllTodoes();
				formData.reset();
				formData.loading = false;
			},
			error => {
				formData.reset();
				formData.loading = false;
			}
		);
	}

	completeTodo(todo: src.Models.Todo) {
		this.todoService.update(todo).subscribe(
			() => {
				this.loadAllTodoes();
			});
	}

	removeTodo(todo: src.Models.Todo) {
		this.todoService.delete(todo.id).subscribe(
			() => {
				this.loadAllTodoes();
			});
	}
}
