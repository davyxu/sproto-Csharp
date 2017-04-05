enum MyCar {
	Monkey =	1
	Monk =	2
	Pig =	3
}


message MyData {
	name  string
	type  MyCar
	int32  int32	// extend standard
	int64  int64	// extend standard
	
	address string
	
	uint32 uint32	// extend standard
	uint64 uint64	// extend standard
	
}

message FakeMyData{
	name  string
	type  MyCar
	int32  int32	// extend standard	
	
}