import { CommentEntity } from "./comment.entity";
import { RoleEntity } from "./role.entity";

export class UserEntity
{
    public userName: string = "";

    public email: string = "";

    public roleId: number = 0;

    public roleName: RoleEntity = new RoleEntity();

    public passwordHash: Uint8Array = new(Uint8Array);

    public passwordSalt: Uint8Array = new(Uint8Array);

    public comment: Array<CommentEntity> = [];
}