import { Injectable } from "@angular/core";
import { ICar } from "./car";
import { HttpClient, HttpErrorResponse} from '@angular/common/http';
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

@Injectable()
export class CarListService{

    private _carServiceUrl = 'http://localhost:51299/api/cars/';

    getCars(): Observable<ICar[]> {
        return this._http.get<ICar[]>(this._carServiceUrl)
        .do(data=> console.log('All: ' + JSON.stringify(data)))
        .catch(this.handleError);

        // return [
        //     {
        //       "id": 1,
        //       "make": "skoda",
        //       "model": "octavia",
        //       "productionYear": null,
        //       "engineSize": 1400,
        //       "horsePower": 150,
        //       "color": "silver"
        //     },
        //     {
        //       "id": 2,
        //       "make": "vw",
        //       "model": "golf",
        //       "productionYear": null,
        //       "engineSize": 1400,
        //       "horsePower": 125,
        //       "color": "white"
        //     }
        //   ];
    }

    private handleError(err: HttpErrorResponse){
        console.log(err.message);
        return Observable.throw(err.message);
    }
    constructor(private _http: HttpClient) {
        
    };

}