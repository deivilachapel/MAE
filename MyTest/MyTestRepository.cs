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

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("aad06e5e-3030-46fa-bb10-cc0cdc6d9fd2")]
    public partial class MyTestRepository : RepoGenBaseFolder
    {
        static MyTestRepository instance = new MyTestRepository();
        MyTestRepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestRepository element repository.
        /// </summary>
        [RepositoryFolder("aad06e5e-3030-46fa-bb10-cc0cdc6d9fd2")]
        public static MyTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestRepository() 
            : base("MyTestRepository", "/", null, 0, false, "aad06e5e-3030-46fa-bb10-cc0cdc6d9fd2", ".\\RepositoryImages\\MyTestRepositoryaad06e5e.rximgres")
        {
            _rxmainframe = new MyTestRepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("aad06e5e-3030-46fa-bb10-cc0cdc6d9fd2")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("d6e46d87-92aa-4885-9b8f-3dda6674f81d")]
        public virtual MyTestRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("d6e46d87-92aa-4885-9b8f-3dda6674f81d")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _testdatabaseInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "d6e46d87-92aa-4885-9b8f-3dda6674f81d", "")
            {
                _testdatabaseInfo = new RepoItemInfo(this, "TestDatabase", "?/?/tabpage[@accessiblename='Test database']", 30000, null, "a1945421-2562-4d93-ba9e-e14144b6c67b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d6e46d87-92aa-4885-9b8f-3dda6674f81d")]
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
            [RepositoryItemInfo("d6e46d87-92aa-4885-9b8f-3dda6674f81d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TestDatabase item.
            /// </summary>
            [RepositoryItem("a1945421-2562-4d93-ba9e-e14144b6c67b")]
            public virtual Ranorex.TabPage TestDatabase
            {
                get
                {
                    return _testdatabaseInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TestDatabase item info.
            /// </summary>
            [RepositoryItemInfo("a1945421-2562-4d93-ba9e-e14144b6c67b")]
            public virtual RepoItemInfo TestDatabaseInfo
            {
                get
                {
                    return _testdatabaseInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
