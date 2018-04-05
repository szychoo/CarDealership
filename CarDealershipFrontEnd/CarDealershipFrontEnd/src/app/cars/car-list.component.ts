import { ICar } from "./car";
import { Component, OnInit } from "@angular/core";
import { CarListService } from "./car-list.service";

@Component({
  selector: 'car-list',
  templateUrl: './car-list.component.html',
  providers: [CarListService]
})

export class CarListComponent implements OnInit{
  
  constructor(private _carListService: CarListService) {
  }

  ngOnInit(): void {
    this.cars = this._carListService.getCars();
  }
  
  cars: ICar[];


  }