﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SocialNetwork.Data;
using System;

namespace SocialNetwork.Data.Migrations
{
    [DbContext(typeof(SocialNetworkContext))]
    [Migration("20170921154234_UsersFriends")]
    partial class UsersFriends
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SocialNetwork.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastTimeLoggedIn");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("ProfilePicture");

                    b.Property<DateTime>("RegisteredOn");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SocialNetwork.Models.UserFriend", b =>
                {
                    b.Property<int>("FirstUserId");

                    b.Property<int>("SecondUserId");

                    b.HasKey("FirstUserId", "SecondUserId");

                    b.HasIndex("SecondUserId");

                    b.ToTable("UsersFriends");
                });

            modelBuilder.Entity("SocialNetwork.Models.UserFriend", b =>
                {
                    b.HasOne("SocialNetwork.Models.User", "FirstUser")
                        .WithMany("Followers")
                        .HasForeignKey("FirstUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialNetwork.Models.User", "SecondUser")
                        .WithMany("Following")
                        .HasForeignKey("SecondUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
