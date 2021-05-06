
export class ExportHistoryEntry {
    constructor(
        public id: number,
        public name: string,
        public user: string,
        public place: string,
        public dateTime: Date
    ) { }
}
