﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Copy_Functionality
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Copy_FunctionalityRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("e42a743b-a3e8-4cbb-9b95-f52faccbdaee")]
    public partial class Copy_FunctionalityRepository : RepoGenBaseFolder
    {
        static Copy_FunctionalityRepository instance = new Copy_FunctionalityRepository();
        Copy_FunctionalityRepositoryFolders.SnapXUntitledAppFolder _snapxuntitled;
        Copy_FunctionalityRepositoryFolders.SnapXCopyMxyAppFolder _snapxcopymxy;

        /// <summary>
        /// Gets the singleton class instance representing the Copy_FunctionalityRepository element repository.
        /// </summary>
        [RepositoryFolder("e42a743b-a3e8-4cbb-9b95-f52faccbdaee")]
        public static Copy_FunctionalityRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Copy_FunctionalityRepository() 
            : base("Copy_FunctionalityRepository", "/", null, 0, false, "e42a743b-a3e8-4cbb-9b95-f52faccbdaee", ".\\RepositoryImages\\Copy_FunctionalityRepositorye42a743b.rximgres")
        {
            _snapxuntitled = new Copy_FunctionalityRepositoryFolders.SnapXUntitledAppFolder(this);
            _snapxcopymxy = new Copy_FunctionalityRepositoryFolders.SnapXCopyMxyAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e42a743b-a3e8-4cbb-9b95-f52faccbdaee")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SnapXUntitled folder.
        /// </summary>
        [RepositoryFolder("13d278db-9880-4db7-a514-5c0b5c50e6bc")]
        public virtual Copy_FunctionalityRepositoryFolders.SnapXUntitledAppFolder SnapXUntitled
        {
            get { return _snapxuntitled; }
        }

        /// <summary>
        /// The SnapXCopyMxy folder.
        /// </summary>
        [RepositoryFolder("1403e8ba-e298-421c-9778-470deba2dc29")]
        public virtual Copy_FunctionalityRepositoryFolders.SnapXCopyMxyAppFolder SnapXCopyMxy
        {
            get { return _snapxcopymxy; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class Copy_FunctionalityRepositoryFolders
    {
        /// <summary>
        /// The SnapXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("13d278db-9880-4db7-a514-5c0b5c50e6bc")]
        public partial class SnapXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebarInfo;

            /// <summary>
            /// Creates a new SnapXUntitled  folder.
            /// </summary>
            public SnapXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXUntitled", "/form[@title='Snap-X - [Untitled]']", parentFolder, 600000, null, true, "13d278db-9880-4db7-a514-5c0b5c50e6bc", "")
            {
                _titlebarInfo = new RepoItemInfo(this, "TitleBar", "element[@controlid='94']", 300000, null, "9c9bfffd-1332-4aec-93b7-6e42afaf4b29");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("13d278db-9880-4db7-a514-5c0b5c50e6bc")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("13d278db-9880-4db7-a514-5c0b5c50e6bc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar item.
            /// </summary>
            [RepositoryItem("9c9bfffd-1332-4aec-93b7-6e42afaf4b29")]
            public virtual Ranorex.Unknown TitleBar
            {
                get
                {
                    return _titlebarInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The TitleBar item info.
            /// </summary>
            [RepositoryItemInfo("9c9bfffd-1332-4aec-93b7-6e42afaf4b29")]
            public virtual RepoItemInfo TitleBarInfo
            {
                get
                {
                    return _titlebarInfo;
                }
            }
        }

        /// <summary>
        /// The SnapXCopyMxyAppFolder folder.
        /// </summary>
        [RepositoryFolder("1403e8ba-e298-421c-9778-470deba2dc29")]
        public partial class SnapXCopyMxyAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _finishInfo;

            /// <summary>
            /// Creates a new SnapXCopyMxy  folder.
            /// </summary>
            public SnapXCopyMxyAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXCopyMxy", "/form[@title='Snap-X - [Copy.mxy]']", parentFolder, 30000, null, true, "1403e8ba-e298-421c-9778-470deba2dc29", "")
            {
                _finishInfo = new RepoItemInfo(this, "Finish", "container[@controlid='59648']/form//button[@text='Finish' and @enabled='True']", 600000, null, "8089a60c-0f3f-42bc-a7be-a94b7a1e69f6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1403e8ba-e298-421c-9778-470deba2dc29")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1403e8ba-e298-421c-9778-470deba2dc29")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Finish item.
            /// </summary>
            [RepositoryItem("8089a60c-0f3f-42bc-a7be-a94b7a1e69f6")]
            public virtual Ranorex.Button Finish
            {
                get
                {
                    return _finishInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Finish item info.
            /// </summary>
            [RepositoryItemInfo("8089a60c-0f3f-42bc-a7be-a94b7a1e69f6")]
            public virtual RepoItemInfo FinishInfo
            {
                get
                {
                    return _finishInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}