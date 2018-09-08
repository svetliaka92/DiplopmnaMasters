clc
close all

fs = fopen('emgData2.txt', 'rt');
tmp = textscan(fs, '%s','Delimiter', '\t');

C = {{1,2,3};{4,5,6}};

tmp1 = cell2mat(C{1,1});
tmp3 = tmp{1,1};

[i,j] = size(tmp3);

A = zeros(i,j);
y = str2num(tmp3{3,1});

for x = 1:i
    A(x,1) = str2num(tmp3{x,1});
end

B = reshape(A, 8, [])
