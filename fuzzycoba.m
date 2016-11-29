a = 5;
b = 15;
c = 25;

for i=1:c+5;
    x(i,1)=i;
    if i <= a
        y(i,1)=0;
    elseif i <= b
        y(i,1)=(i-a)/(b-a);
    elseif i <= c
        y(i,1)=(i-c)/(b-c);
    else
        y(i,1)=0;
    end
end;
plot(x,y)
