using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Debugging;
using RecRoom.Initialization;
using RecRoom.Localization;
using RecRoom.Networking;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.Common.Delegates;
using RecRoom.Notifications;
using RecRoom.Persistence;
using RecRoom.Protobuf;
using UJect;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_UGCLocalization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9580400", Offset = "0x957F000", VA = "0x189580400", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.UGCLocalization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class BOCESJYEIUO : XXKKKYKOWUH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class GJCYRYJHJWZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public enum RequestState
			{
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				Needed = 0,
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				Requested = 1,
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				Default = 0
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public enum RequestorOperationResult
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				None,
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				Modified,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				AddedFirstOrRemovedLast
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly HashSet<HADOMKANPWQ> SLOKPFSDNKU;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public UGCScopedTranslationDTO QOPWJDROQCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool FSOSNTTTXPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x9579F80", Offset = "0x9578B80", VA = "0x189579F80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool YGPMGQNFECK
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x957A060", Offset = "0x9578C60", VA = "0x18957A060")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public RequestState KTKPQYQLPUM
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
				[CompilerGenerated]
				get
				{
					return default(RequestState);
				}
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x957A2D0", Offset = "0x9578ED0", VA = "0x18957A2D0")]
			public GJCYRYJHJWZ(HADOMKANPWQ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x957A130", Offset = "0x9578D30", VA = "0x18957A130")]
			public GJCYRYJHJWZ(UGCScopedTranslationDTO a, HADOMKANPWQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x957A0B0", Offset = "0x9578CB0", VA = "0x18957A0B0")]
			public int ZPGDQMORMYB(UGCScopedTranslationDTO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9579EF0", Offset = "0x9578AF0", VA = "0x189579EF0")]
			public RequestorOperationResult VHGRSUXZZFO(HADOMKANPWQ a)
			{
				return default(RequestorOperationResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9579FA0", Offset = "0x9578BA0", VA = "0x189579FA0")]
			public RequestorOperationResult WFGGLGPTODJ(HADOMKANPWQ a)
			{
				return default(RequestorOperationResult);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <<-ctor>b__49_0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public BOCESJYEIUO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public APQTHAEMUEW deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x957EF30", Offset = "0x957DB30", VA = "0x18957EF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x957F3C0", Offset = "0x957DFC0", VA = "0x18957F3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class XBXPCOCNZHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public KeyValuePair<string, UGCScopedTranslationDTO> CXVOMNPINWB;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XBXPCOCNZHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x957FD20", Offset = "0x957E920", VA = "0x18957FD20")]
			internal object KLAIGTHHSVJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OZTZWOTWTBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public string PPBIMFVCQQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public BOCESJYEIUO VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public GJCYRYJHJWZ DBQHUADBCNR;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OZTZWOTWTBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x957A5B0", Offset = "0x95791B0", VA = "0x18957A5B0")]
			internal object DGDAUNULADM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x957A6F0", Offset = "0x95792F0", VA = "0x18957A6F0")]
			internal object DGIHRUOIJOV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OZOSZHZZJPS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public long VOAKIUTANGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public OZTZWOTWTBB JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OZOSZHZZJPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x957A500", Offset = "0x9579100", VA = "0x18957A500")]
			internal object DFSNAAGQHGU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PAENRCHRLXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public string VZWNNAJDGGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public OZTZWOTWTBB JZOZKHWTGTV;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PAENRCHRLXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x957A740", Offset = "0x9579340", VA = "0x18957A740")]
			internal object DFXTXHANQSD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HLJKPBECSVI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public HADOMKANPWQ VEPPQSSRIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public string PPBIMFVCQQP;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HLJKPBECSVI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x957A330", Offset = "0x9578F30", VA = "0x18957A330")]
			internal object TMBMRGJXPYR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x957A2E0", Offset = "0x9578EE0", VA = "0x18957A2E0")]
			internal object TLWFTZQAGNI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class QLWLAMNHUHQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public List<UGCScopedTranslationDTO> RDTVNERLDKF;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QLWLAMNHUHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x957A860", Offset = "0x9579460", VA = "0x18957A860")]
			internal object BFEINNQLQSS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IYYKLORVOJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public UGCStringAutoLocalizationJobNotificationDTO YHPQNWUVPNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public BOCESJYEIUO VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IYYKLORVOJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x957A450", Offset = "0x9579050", VA = "0x18957A450")]
			internal object TQJTQURYPDH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x957A3E0", Offset = "0x9578FE0", VA = "0x18957A3E0")]
			internal object TPZFWHEDWGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x957A4E0", Offset = "0x95790E0", VA = "0x18957A4E0")]
			internal void TREVFVTOAWR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class XATCOWUGWSY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int VAWIOUZJUBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public BOCESJYEIUO VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XATCOWUGWSY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x957FC70", Offset = "0x957E870", VA = "0x18957FC70")]
			internal object SUQGLRVUIED()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class UBAQQPREKOZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public BOCESJYEIUO VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public List<string> NSYNMNVZBUI;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UBAQQPREKOZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x957FB00", Offset = "0x957E700", VA = "0x18957FB00")]
			internal object GQRVTIIYXKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x957FBF0", Offset = "0x957E7F0", VA = "0x18957FBF0")]
			internal object YKPFSNSAGES()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <GetOrWaitForTranslations>d__61 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public BOCESJYEIUO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public IEnumerable<ABLNPBVPOUZ> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private QLWLAMNHUHQ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private TaskAwaiter<List<UGCScopedTranslationDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x957B360", Offset = "0x9579F60", VA = "0x18957B360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x957BDC0", Offset = "0x957A9C0", VA = "0x18957BDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <GetTranslations>d__60 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AsyncTaskMethodBuilder<List<UGCScopedTranslationDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BOCESJYEIUO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool logExceptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<UGCLocalizedContentResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x957BE20", Offset = "0x957AA20", VA = "0x18957BE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x957C2B0", Offset = "0x957AEB0", VA = "0x18957C2B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <PreSerializeAsync>d__64 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public BOCESJYEIUO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private UBAQQPREKOZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Dictionary<string, GJCYRYJHJWZ> <neededTranslationLookup>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Guid <nextScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x957C320", Offset = "0x957AF20", VA = "0x18957C320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x957E0D0", Offset = "0x957CCD0", VA = "0x18957E0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <ReacquireTranslations>d__63 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public BOCESJYEIUO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private XATCOWUGWSY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<List<UGCScopedTranslationDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x957E130", Offset = "0x957CD30", VA = "0x18957E130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x957EED0", Offset = "0x957DAD0", VA = "0x18957EED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		internal static bool CCARNJBUAWQ;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal static string THEDJZUICTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly YKQLXSEJKLS AYZWKPHPHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly APGJYUSDVFP MFELRBZPDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly VDCIXCLHTKX VHXNYSMFVGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UUHHFVJYLXY MUIQRGUFNSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string VGKHICOQOQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly IDisposable AQZDKIACWTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, GJCYRYJHJWZ> EXTIPTQGACX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, UGCScopedTranslationDTO> LYFNTQFNRPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int GBAFJFDGJFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool NXVUDBFPMAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long JVXGCUYONRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private long ZHLXLZZXNGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Guid TUNIJUVNYYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool XXQPTZLHYSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly bool JEKCATTIIOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int? GRBQQAOAXMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool OOWOSIIAGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly HashSet<LATOEPQNEFS> JJTQUFRXHNK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal Guid XNWGXHHRQSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x4414DD0", Offset = "0x44139D0", VA = "0x184414DD0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9577ED0", Offset = "0x9576AD0", VA = "0x189577ED0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private long IKDXOFHMFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9577AF0", Offset = "0x95766F0", VA = "0x189577AF0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string AJSKXARUZFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB1D760", Offset = "0xB1C360", VA = "0x180B1D760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private string JRAZVPNDXYW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9578900", Offset = "0x9577500", VA = "0x189578900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal bool ABRETZACXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9578190", Offset = "0x9576D90", VA = "0x189578190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal bool HOICICVKSZM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9578080", Offset = "0x9576C80", VA = "0x189578080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal bool AMANALQVWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9578D30", Offset = "0x9577930", VA = "0x189578D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HENPTTOAGFU
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9578C00", Offset = "0x9577800", VA = "0x189578C00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private static LogFlags HDBJTGKOWDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9577A90", Offset = "0x9576690", VA = "0x189577A90")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private int LIOVSXTBIKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x95787A0", Offset = "0x95773A0", VA = "0x1895787A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9579690", Offset = "0x9578290", VA = "0x189579690")]
		private static void ZPABACRNKCM(MessageFunc a, LogFlags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9577F90", Offset = "0x9576B90", VA = "0x189577F90")]
		[IFIZWETSKCB.Room.GameOnly]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9579740", Offset = "0x9578340", VA = "0x189579740")]
		[RecRoom.NoEngine.Common.Preserve]
		internal BOCESJYEIUO([Inject(null)][NotNull] YKQLXSEJKLS recNetStringService, [Inject(null)][NotNull] APGJYUSDVFP recNetAccounts, [Inject(null)][NotNull] VDCIXCLHTKX matchmakingProvider, [Inject(null)][NotNull] ZUUCGYXVQOS networking, [Inject(null)][NotNull] UUHHFVJYLXY notificationManager, [Inject(null)][NotNull] CXTDTRBEZCM localizationService, [Inject(null)][NotNull] BFGWYOYOWEM roomLoader, [Inject(null)][NotNull] EDFELDUZHLG gameConfigsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x95775F0", Offset = "0x95761F0", VA = "0x1895775F0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9578B90", Offset = "0x9577790", VA = "0x189578B90")]
		private static string RIGGUVXWYVU(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9578570", Offset = "0x9577170", VA = "0x189578570")]
		private Dictionary<string, UGCScopedTranslationDTO> NIRYGOSYFUE(IEnumerable<UGCScopedTranslationDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9577760", Offset = "0x9576360", VA = "0x189577760")]
		private void EAMORJGZTXX(Dictionary<string, UGCScopedTranslationDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9577BC0", Offset = "0x95767C0", VA = "0x189577BC0")]
		internal static string GTQKJWFGNUD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x95786E0", Offset = "0x95772E0", VA = "0x1895786E0", Slot = "4")]
		public bool NXIKOZYHYCH(LATOEPQNEFS a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9577A40", Offset = "0x9576640", VA = "0x189577A40", Slot = "7")]
		public string ESQCPWQDQVB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9578F00", Offset = "0x9577B00", VA = "0x189578F00", Slot = "8")]
		public TranslationState WDGTFDBZHOC(string a, string b, [CanBeNull] HADOMKANPWQ requestor)
		{
			return default(TranslationState);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x95781E0", Offset = "0x9576DE0", VA = "0x1895781E0", Slot = "9")]
		public void MTFVWRDNPVA(string a, [NotNull] HADOMKANPWQ requestor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9577300", Offset = "0x9575F00", VA = "0x189577300", Slot = "10")]
		public TranslationRequestResult BYSOIJXHSFC(string a)
		{
			return default(TranslationRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9578A90", Offset = "0x9577690", VA = "0x189578A90")]
		[AsyncStateMachine(typeof(<GetTranslations>d__60))]
		private Task<List<UGCScopedTranslationDTO>> PDRMKLPLENN(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9577DD0", Offset = "0x95769D0", VA = "0x189577DD0")]
		[AsyncStateMachine(typeof(<GetOrWaitForTranslations>d__61))]
		private Task GetOrWaitForTranslations(IEnumerable<ABLNPBVPOUZ> persistenceViews)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9576A80", Offset = "0x9575680", VA = "0x189576A80")]
		private void AFFABCAGIFJ(UGCStringAutoLocalizationJobNotificationDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9577230", Offset = "0x9575E30", VA = "0x189577230")]
		[AsyncStateMachine(typeof(<ReacquireTranslations>d__63))]
		private Task BBFLJUVLJRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x95787E0", Offset = "0x95773E0", VA = "0x1895787E0", Slot = "11")]
		[AsyncStateMachine(typeof(<PreSerializeAsync>d__64))]
		public Task OUJSHJOGZNS(SerializeType a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9578CA0", Offset = "0x95778A0", VA = "0x189578CA0", Slot = "5")]
		public void SerializeTo(PersistedRoomData roomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9578D50", Offset = "0x9577950", VA = "0x189578D50")]
		private void UEGVKZPMJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x95789A0", Offset = "0x95775A0", VA = "0x1895789A0")]
		[AsyncStateMachine(typeof(<<-ctor>b__49_0>d))]
		[CompilerGenerated]
		private Task OXSHWFSFAWL(APQTHAEMUEW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9578940", Offset = "0x9577540", VA = "0x189578940")]
		[CompilerGenerated]
		private object OXNAYYYHRLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x95780D0", Offset = "0x9576CD0", VA = "0x1895780D0")]
		[CompilerGenerated]
		private string KWJOIGKPUPO(UGCScopedTranslationDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x95774D0", Offset = "0x95760D0", VA = "0x1895774D0")]
		[CompilerGenerated]
		private object CGKNQDTBERC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9577560", Offset = "0x9576160", VA = "0x189577560")]
		[CompilerGenerated]
		private object CGPUNKMYOCL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal class CVIVYCBAUMF : HADOMKANPWQ, IEquatable<HADOMKANPWQ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public long AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string JKJORIMASLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9579E50", Offset = "0x9578A50", VA = "0x189579E50")]
		public CVIVYCBAUMF(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9579DE0", Offset = "0x95789E0", VA = "0x189579DE0", Slot = "7")]
		public bool Equals(HADOMKANPWQ rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2DCDE80", Offset = "0x2DCCA80", VA = "0x182DCDE80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal class TBKWLHIPBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly XXKKKYKOWUH NHLVQPYREHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private HADOMKANPWQ VEPPQSSRIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool ALYUXRAEQFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private string FUYJWBLGFUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private string KFRYZTAHFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private bool HOUXBHNHFCK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal long ECTSNJDBXET
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x957AA30", Offset = "0x9579630", VA = "0x18957AA30")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string JKJORIMASLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x957A9E0", Offset = "0x95795E0", VA = "0x18957A9E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x957AA80", Offset = "0x9579680", VA = "0x18957AA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x957B240", Offset = "0x9579E40", VA = "0x18957B240")]
		public TBKWLHIPBHI([Optional] XXKKKYKOWUH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x957AC60", Offset = "0x9579860", VA = "0x18957AC60")]
		public TranslationRequestResult SJTQQAMZXPQ(LATOEPQNEFS a)
		{
			return default(TranslationRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x957ADA0", Offset = "0x95799A0", VA = "0x18957ADA0")]
		internal void Update(LATOEPQNEFS dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x957A9D0", Offset = "0x95795D0", VA = "0x18957A9D0")]
		public void Cleanup(LATOEPQNEFS dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x957AB40", Offset = "0x9579740", VA = "0x18957AB40")]
		private void MTFVWRDNPVA(LATOEPQNEFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x957A980", Offset = "0x9579580", VA = "0x18957A980")]
		[CompilerGenerated]
		private object BQZQKMRQOEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x957A8F0", Offset = "0x95794F0", VA = "0x18957A8F0")]
		[CompilerGenerated]
		private object BQUJNFXTESY()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class YBEYLKMMFAC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LATOEPQNEFS LXTKLRERRZS
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x957FEA0", Offset = "0x957EAA0", VA = "0x18957FEA0")]
		public YBEYLKMMFAC(LATOEPQNEFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x957FE50", Offset = "0x957EA50", VA = "0x18957FE50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ZGCIJDMFVDT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly LATOEPQNEFS KLZSSXYHCFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly TBKWLHIPBHI TKJOZHMIWKX;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public TranslationRequestResult HKVUZYEFNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x957FF80", Offset = "0x957EB80", VA = "0x18957FF80")]
			get
			{
				return default(TranslationRequestResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool RWDFQHQELQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string JKJORIMASLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x95800D0", Offset = "0x957ECD0", VA = "0x1895800D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x95801B0", Offset = "0x957EDB0", VA = "0x1895801B0")]
		public ZGCIJDMFVDT(LATOEPQNEFS a, [Optional] XXKKKYKOWUH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x957FF40", Offset = "0x957EB40", VA = "0x18957FF40")]
		public void GCNEUTNOQUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x957FF20", Offset = "0x957EB20", VA = "0x18957FF20")]
		public void Cleanup()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
