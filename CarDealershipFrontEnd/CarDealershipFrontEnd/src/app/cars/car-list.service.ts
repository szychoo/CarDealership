import { Injectable } from "@angular/core";
import { ICar } from "./car";

@Injectable()
export class CarListService{
    getCars(): ICar[] {
        return [
            {
              "id": 1,
              "make": "skoda",
              "model": "octavia",
              "productionYear": null,
              "engineSize": 1400,
              "horsePower": 150,
              "color": "silver"
            },
            {
              "id": 2,
              "make": "vw",
              "model": "golf",
              "productionYear": null,
              "engineSize": 1400,
              "horsePower": 125,
              "color": "white"
            }
          ];
    }
}