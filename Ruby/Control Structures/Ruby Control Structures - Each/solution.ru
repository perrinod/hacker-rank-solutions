#https://www.hackerrank.com/challenges/ruby-tutorial-each/problem
def scoring(array)
    array.each do |user|
        user.update_score
    end
end