import { Component, OnInit } from '@angular/core';
import { Material } from '../../models/material';

@Component({
  selector: 'app-materials',
  templateUrl: './materials.component.html',
  styleUrls: ['./materials.component.css']
})
export class MaterialsComponent implements OnInit {
  materials: Material[] = [{ id: 1, name: "PET Бутылочный", materialTypeId: 1, materialTypeName: "Пластик", materialSubTypeId: 1, materialSubTypeName: "PET", image: "", description: "" },
    { id: 2, name: "PET Небутылочный Прозрачный", materialTypeId: 1, materialTypeName: "Пластик", materialSubTypeId: 1, materialSubTypeName: "PET",  image: "", description: "" }]
  constructor() { }

  ngOnInit() {
  }

}
