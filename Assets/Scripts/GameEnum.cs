﻿public enum NodeState
{
    None,
    Init,
    Start,
    Running,
    WaitForChild,
    Complete,
    Disable
}

public enum NodeType
{
    Root,
    Selector,
    Sequencer,
    Action
}

public enum ActionState
{
    None,
    Start,
    Running,
    Finished
}

public enum ExecuteResultState
{
    None,
    Success,
    Failure
}