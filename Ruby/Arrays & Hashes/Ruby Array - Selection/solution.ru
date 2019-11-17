#https://www.hackerrank.com/challenges/ruby-array-selection/problem
def select_arr(arr)
    arr.select{|a| a % 2 != 0};
  end
  
  def reject_arr(arr)
      arr.select{|a| a % 3 != 0};
  end
  
  def delete_arr(arr)
      arr.reject{|a| a <= 0};
  end
  
  def keep_arr(arr)
      arr.drop_while{|a| a <= 0};
  end