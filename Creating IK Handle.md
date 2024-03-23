import maya.cmds as cmds

def create_ik_handle(start_joint, end_joint, solver_type='ikRPsolver', name='ikHandle'):
    ik_handle, effector = cmds.ikHandle(sj=start_joint, ee=end_joint, sol=solver_type, name=name)
    return ik_handle, effector

# Example usage:
start_joint = 'joint01_JNT'
end_joint = 'joint05_JNT'
ik_handle, effector = create_ik_handle(start_joint, end_joint)
print(ik_handle, effector)

//Code from ChatGBT
