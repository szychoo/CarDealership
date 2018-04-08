import { ICar } from "./car";
import { Component, OnInit } from "@angular/core";
import { CarListService } from "./car-list.service";

@Component({
  selector: 'car-list',
  templateUrl: './car-list.component.html',
  providers: [CarListService]
})

export class CarListComponent implements OnInit{
  
  errorMessage: string;

  constructor(private _carListService: CarListService) {
  }

  ngOnInit(): void {
    this._carListService.getCars().subscribe(
      cars => this.cars = cars,
      error => this.errorMessage = <any>error
    );
  }
  
  cars: ICar[];


  }