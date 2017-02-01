using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Newtonsoft.Json;
using src.DAL;
using src.Models;

namespace src.API.Controllers
{
	public class TodoesController : ApiController
	{
		private ApplicationDbDataContext db = new ApplicationDbDataContext();

		/// <summary> [create] POST: api/Todoes </summary>
		[ResponseType(typeof(Todo))]
		public IHttpActionResult PostTodo(Todo todo)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			Todoes todoData = new Todoes
			{
				Title = todo.Title,
				Completed = todo.Completed
			};

			db.Todoes.InsertOnSubmit(todoData);
			db.SubmitChanges();

			return CreatedAtRoute("DefaultApi", new { Id = todoData.Id }, todoData);
		}

		/// <summary> [readAll] GET: api/Todoes </summary>
		public List<Todoes> GetTodoes()
		{
			return db.Todoes.ToList();
		}

		/// <summary> [update] PUT: api/Todoes/5 </summary>
		[ResponseType(typeof(void))]
		public IHttpActionResult PutTodo(int Id, Todo todo)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (Id != todo.Id)
			{
				return BadRequest();
			}

			Todoes todoData = db.Todoes.Where(row => row.Id == Id).SingleOrDefault();

			if (todoData == null)
			{
				return NotFound();
			}

			todoData.Title = todo.Title;
			todoData.Completed = todo.Completed;
			db.SubmitChanges();

			return Ok(todoData);
		}

		/// <summary> [delete] DELETE: api/Todoes/5 </summary>
		[ResponseType(typeof(Todo))]
		public IHttpActionResult DeleteTodo(int Id)
		{
			//var todoData = db.Todoes.Where(row => row.Id == Id); // Multiple
			Todoes todoData = db.Todoes.Where(row => row.Id == Id).SingleOrDefault();

			if (todoData == null)
			{
				return NotFound();
			}

			//db.Todoes.DeleteAllOnSubmit(todoData); // Multiple
			db.Todoes.DeleteOnSubmit(todoData);
			db.SubmitChanges();

			return Ok(todoData);
		}
	}
}
