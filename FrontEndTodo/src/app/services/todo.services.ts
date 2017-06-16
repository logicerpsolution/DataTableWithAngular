import { Http, Response, Headers, RequestOptions } from '@angular/http';
import {Injectable} from '@angular/core'
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

 @Injectable()
 export class  TodoService{


    private baseUrl:string="http://localhost:65279/api/todo";
      constructor(private http:Http){


      }

     GetTodoList():Observable<any>{
            return this.http.get(this.baseUrl)
            .map((res:Response) =><any> res.json())
            .catch((error:any)=>Observable.throw(error.json().error || 'Server error'))
     }

  }

