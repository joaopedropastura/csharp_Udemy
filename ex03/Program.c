#include<stdio.h>
#include<string.h>
#include<stdlib.h>

typedef struct{
   char nome[30];
   float cr;
}aluno;

int main(){
   int i;
   aluno a[5];
	float c;
	char n[30];
    // sua resposta será inserida aqui
	for(i=0;i<5;i++)
	{
		// fgets(a[i].nome, 31,stdin);
		scanf("%s", &n);
		*a[i].nome = n;
		scanf("%f", &c);
		a[i].cr = c;
	}
	aluno temp;
	for(i=0;i<5;i++)
	{
		for (int j = 0; j < 4;j++)
		{
			if(a[i].cr < a[j].cr)
			{
				temp = a[i];
				a[i] = a[j];
				a[j] = temp;
			}
		}
	}
	printf("\n\n\n\n");


   for(i=0;i<5;i++)
      printf("%s%.2f\n",a[i].nome,a[i].cr);
   return 0;
}

