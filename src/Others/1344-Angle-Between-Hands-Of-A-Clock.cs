public class Solution {
    public double AngleClock(int hour, int minutes) {            
        
        double minAngle = minutes * 6;
        double hourAngle = (double)minutes / 2 + hour * 30;
        double angle = Math.Abs(hourAngle - minAngle);
        return angle > 180 ? 360 - angle: angle;                                    
    }
}
