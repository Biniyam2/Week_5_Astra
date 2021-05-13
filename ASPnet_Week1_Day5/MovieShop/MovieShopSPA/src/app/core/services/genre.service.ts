import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Genre } from 'src/app/shared/models/genre';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private apiService:ApiService) { }
  getAllGenres() : Observable<Genre[]>
  {
    //call getList from api service
   return this.apiService.getList('genres');
  }
}
