import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

@Injectable()
export class TodoService {
	constructor(
		private http: Http
	) { }

	private requestOptions = new RequestOptions({
		headers: new Headers({
			'Content-Type': 'application/json'
		})
	});

	create(todo: src.Models.Todo) {
		return this.http.post('/api/Todoes', todo, this.requestOptions)
			.map((response: Response) => response.json());
	}

	readAll() {
		return this.http.get('/api/Todoes', this.requestOptions)
			.map((response: Response) => response.json());
	}

	update(todo: src.Models.Todo) {
		return this.http.put('/api/Todoes/' + todo.Id, todo, this.requestOptions)
			.map((response: Response) => response.json());
	}

	delete(Id: number) {
		return this.http.delete('/api/Todoes/' + Id, this.requestOptions)
			.map((response: Response) => response.json());
	}
}
