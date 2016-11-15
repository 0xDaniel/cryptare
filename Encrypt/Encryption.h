#pragma once
class Foo {
public:
	int Bar();
};
Foo* Foo_Create() { return new Foo(); }
int Foo_Bar(Foo* pFoo) { return pFoo->Bar(); }
void Foo_Delete(Foo* pFoo) { delete pFoo; }