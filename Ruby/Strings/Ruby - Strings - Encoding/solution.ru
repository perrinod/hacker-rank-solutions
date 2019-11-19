#https://www.hackerrank.com/challenges/ruby-strings-encoding/problem
def transcode(string)
    string.force_encoding(Encoding::UTF_8)
end