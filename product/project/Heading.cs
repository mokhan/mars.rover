using System;

namespace mars.rover
{
    public interface Heading : IEquatable<Heading>
    {
        Heading turn_left();
        Heading turn_right();
        void move_forward_from(Coordinate x, Coordinate y);
    }
}