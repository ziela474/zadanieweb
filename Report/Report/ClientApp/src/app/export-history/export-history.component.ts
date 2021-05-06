import { Component, OnInit } from '@angular/core';
import { ExportHistoryEntry } from '../models/models';
import { ApiService } from '../service/api.service';
import {NgbDateStruct, NgbCalendar} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-export-history',
  templateUrl: './export-history.component.html',
  styleUrls: ['./export-history.component.css']
})
export class ExportHistoryComponent implements OnInit {
  ExportHistory: ExportHistoryEntry[];
  model: NgbDateStruct;
  date: {year: number, month: number};
  constructor(private apiService: ApiService, private calendar: NgbCalendar) { }
  ngOnInit(): void {

  }

  
}
