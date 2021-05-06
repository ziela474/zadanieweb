import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "./../../environments/environment";
import { concat, Observable, throwError } from "rxjs";
import { Place } from "../models/models";
import { ExportHistoryEntry } from "../models/models";

@Injectable({
  providedIn: "root",
})
export class ApiService {
  getAllPlacesEndpoint = "/api/Report/GetAllPlaces";
  getExportHistoryEndpoint = "/api/Report/GetExportHistory";
  constructor(private http: HttpClient) {}

  httpOptions = {
    headers: new HttpHeaders({
      "Content-Type": "application/json",
    }),
  };
  getAllPlaces(): Observable<Place[]> {
    return this.http.get<Place[]>(environment.apiUrl + this.getAllPlaces);
  }

  getExportHistory(
    placeId: number,
    startDate: Date,
    endDate: Date
  ): Observable<ExportHistoryEntry[]> {
    let url =
      environment.apiUrl +
      this.getExportHistoryEndpoint +
      `?placeId=${placeId}&startDate=${startDate}&endDate=${endDate}`;
    return this.http.get<ExportHistoryEntry[]>(
      environment.apiUrl + this.getExportHistoryEndpoint
    );
  }
}
