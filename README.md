# UnityOnRailScript
On Rails Script For Unity: (Used in a VR Project that took 8 weeks)

Each Script is responsible for the following for the following:

Rail.cs: This script is designed to assist the developer in creating a railway track within the Unity Editor. It uses gizmos to visually draw lines between nodes, which represent the track’s path. The developer can add these nodes through the editor interface. Additionally, the script offers an option to choose between two types of path interpolation: ‘Linear’ for direct point-to-point paths, or ‘Catmull’ for smoother, Catmull-Rom spline-based paths.

Mover.cs: This script is responsible for moving the player along the rail. While the methods that define how the player moves are contained within Rail.cs, Mover.cs manages the traversal logic. It checks the type of movement (e.g., forward or backward), whether traversal has been completed, and other related conditions.

switchRail.cs: This script enables the player character to switch between different paths. Although it’s possible that this functionality could have been integrated into Rail.cs or Mover.cs, SwitchRail.cs was created separately to fulfill this specific need quickly due to time constraints.
