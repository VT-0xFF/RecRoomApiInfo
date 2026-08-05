using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using UJect;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x812FEA0", Offset = "0x812F2A0", VA = "0x18812FEA0", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] NXGLGIJHSDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] NXLSDPDFBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset XVMTEOAFOEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset XVHMHHGIETQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FA10", Offset = "0x1F1EE10", VA = "0x181F1FA10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x813B540", Offset = "0x813A940", VA = "0x18813B540")]
		private void CRWDOIATXLP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x813B3F0", Offset = "0x813A7F0", VA = "0x18813B3F0")]
		private void CRQWRBGWOAG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x813B690", Offset = "0x813AA90", VA = "0x18813B690", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x813B9A0", Offset = "0x813ADA0", VA = "0x18813B9A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : FFKFPVCXATG, TQNNQAWTERF
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class IVVADQKFTOW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ZHLEOSYTUAE HCRCWRWXHYK;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IVVADQKFTOW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8128C50", Offset = "0x8128050", VA = "0x188128C50")]
			internal object VUACIYCRQYN(ZHLEOSYTUAE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class IWAHAXEDDAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ZHLEOSYTUAE LXQTDGNSLMU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IVVADQKFTOW VHOTALYTHEL;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IWAHAXEDDAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8128CC0", Offset = "0x81280C0", VA = "0x188128CC0")]
			internal object VTUVLRIUHNE((ZHLEOSYTUAE child, ZHLEOSYTUAE nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class RWPHERWXNHH : IEnumerable<MPUJEONHAIN>, IEnumerable, IEnumerator<MPUJEONHAIN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private MPUJEONHAIN FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId DYOBYKNIEOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId GLDGASYIICT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private JSWMMVJFEVL PSRZSDDVYHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray HKMFWNIJPAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator DJDVWSMFCXG;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private MPUJEONHAIN EBKRBRHDAML
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
			[DebuggerHidden]
			public RWPHERWXNHH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8137910", Offset = "0x8136D10", VA = "0x188137910", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8137AE0", Offset = "0x8136EE0", VA = "0x188137AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8137E40", Offset = "0x8137240", VA = "0x188137E40")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8137E60", Offset = "0x8137260", VA = "0x188137E60")]
			private void UOLVUANWIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x81379F0", Offset = "0x8136DF0", VA = "0x1881379F0", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8137A30", Offset = "0x8136E30", VA = "0x188137A30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MPUJEONHAIN> TNAAZFRLBMY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8137A30", Offset = "0x8136E30", VA = "0x188137A30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log YKNZUXIHAYZ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log QWWZEUOWMNP;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log NFFULQBDLJL;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log VTSQLUBRKDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JQRRHNKTKBK AKRIGVFHWWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LCTIHLIGPWP NHAMNPIXBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HFWVSFYRVDA NKKMXZUYRIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NHUCTQIRRTC NLKAWVWHGGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ANNNVJXYLXO UQIKGCDIEVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EDYZMZJMGPK TJAGVSNTOZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MFKMAMOKPND EOULDPYDLBA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KZSKNTWAFUV
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAAF030", Offset = "0xAAE430", VA = "0x180AAF030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAE7E0", Offset = "0xAADBE0", VA = "0x180AAE7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool TCBTBFWIKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN> TBFHZMRBGWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8135730", Offset = "0x8134B30", VA = "0x188135730", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8131E10", Offset = "0x8131210", VA = "0x188131E10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN> NQQAIDSOTGK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8134860", Offset = "0x8133C60", VA = "0x188134860", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8131A90", Offset = "0x8130E90", VA = "0x188131A90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN, MPUJEONHAIN> IOGVIWXIFSK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x81314C0", Offset = "0x81308C0", VA = "0x1881314C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8131B40", Offset = "0x8130F40", VA = "0x188131B40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8135A30", Offset = "0x8134E30", VA = "0x188135A30")]
		public OMConnectableManager(NAWAUUZVKFS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8131F70", Offset = "0x8131370", VA = "0x188131F70", Slot = "12")]
		public void Initialize(GameObject gameObject, WGPTSJRFOJV configData, GRZXFGGAZBO sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8134910", Offset = "0x8133D10", VA = "0x188134910", Slot = "26")]
		public void WKEWZWNCPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8135870", Offset = "0x8134C70", VA = "0x188135870", Slot = "22")]
		public bool ZDDYRTGJYEO(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8132D70", Offset = "0x8132170", VA = "0x188132D70")]
		private void OXZOWBKIXEL(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8134B90", Offset = "0x8133F90", VA = "0x188134B90")]
		private void XVLCIILXPLX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8133410", Offset = "0x8132810", VA = "0x188133410")]
		private void RTOGIKZLAPF(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8135320", Offset = "0x8134720", VA = "0x188135320")]
		private void YQPQVBDOZOY(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81328E0", Offset = "0x8131CE0", VA = "0x1881328E0", Slot = "14")]
		public void MKOAUOREKWX(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "15")]
		public void VYJCJCEGTXK(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8133170", Offset = "0x8132570", VA = "0x188133170", Slot = "17")]
		public void RRDDCRMCRPZ(MPUJEONHAIN a, MPUJEONHAIN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81332D0", Offset = "0x81326D0", VA = "0x1881332D0")]
		public void RRDDCRMCRPZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8132570", Offset = "0x8131970", VA = "0x188132570")]
		public void KFCIHPRWRYB(MPUJEONHAIN a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8131360", Offset = "0x8130760", VA = "0x188131360", Slot = "18")]
		public void AVYXLUPFTQZ(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8134AE0", Offset = "0x8133EE0", VA = "0x188134AE0")]
		private float XATPOFDKSCP(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8131220", Offset = "0x8130620", VA = "0x188131220")]
		public void AVYXLUPFTQZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81351B0", Offset = "0x81345B0", VA = "0x1881351B0", Slot = "19")]
		public void YEDDWIZESVH(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8133670", Offset = "0x8132A70", VA = "0x188133670", Slot = "16")]
		public void SKDIJZQJKPZ(MPUJEONHAIN a, HashSet<MPUJEONHAIN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "20")]
		public ConnectableGraphData OKQGMGVAWXS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "21")]
		public ConnectableGraphData IJESOXGVMQU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8131570", Offset = "0x8130970", VA = "0x188131570", Slot = "23")]
		public void BNLYPPNRWEB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8131EC0", Offset = "0x81312C0", VA = "0x188131EC0", Slot = "24")]
		public void HIFALGLCRDD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81358C0", Offset = "0x8134CC0", VA = "0x1881358C0", Slot = "25")]
		public void ZRHAJCKGFIS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8134DB0", Offset = "0x81341B0", VA = "0x188134DB0")]
		private void XZPIBMXBLEJ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8133880", Offset = "0x8132C80", VA = "0x188133880")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8132F80", Offset = "0x8132380", VA = "0x188132F80")]
		private void PQHARVXFDCG(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81357E0", Offset = "0x8134BE0", VA = "0x1881357E0")]
		[IteratorStateMachine(typeof(RWPHERWXNHH))]
		public IEnumerable<MPUJEONHAIN> YUCTBBPHRSP(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8131960", Offset = "0x8130D60", VA = "0x188131960")]
		internal MPUJEONHAIN CZUKRGMFNMA(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81322D0", Offset = "0x81316D0", VA = "0x1881322D0")]
		internal ObjectLocalId JOGIUTOCKEA(MPUJEONHAIN a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81342E0", Offset = "0x81336E0", VA = "0x1881342E0")]
		private bool UNNUJKKILUZ(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8132600", Offset = "0x8131A00", VA = "0x188132600")]
		private bool KJETUAQAWPP(ZHLEOSYTUAE a, [Out] MPUJEONHAIN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81315E0", Offset = "0x81309E0", VA = "0x1881315E0")]
		private MPUJEONHAIN CZUKRGMFNMA(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8132FF0", Offset = "0x81323F0", VA = "0x188132FF0")]
		private MPUJEONHAIN PWEXUWVKAYR(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8131C50", Offset = "0x8131050", VA = "0x188131C50")]
		private MPUJEONHAIN FKMTYLWNYGK(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8131F30", Offset = "0x8131330", VA = "0x188131F30")]
		private static Guid IBKPXTEBLFF(ZHLEOSYTUAE a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81321E0", Offset = "0x81315E0", VA = "0x1881321E0")]
		private string JHKWYEMBQPU(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8134150", Offset = "0x8133550", VA = "0x188134150")]
		private void TARSCQDLJYB(MPUJEONHAIN a, MPUJEONHAIN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8131090", Offset = "0x8130490", VA = "0x188131090")]
		private void AQJZETGNTGL(MPUJEONHAIN a, MPUJEONHAIN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8131BF0", Offset = "0x8130FF0", VA = "0x188131BF0")]
		private void EPOVAYDNFFH(MPUJEONHAIN a, MPUJEONHAIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8132BE0", Offset = "0x8131FE0", VA = "0x188132BE0")]
		private void OGDJLUUWNKM(MPUJEONHAIN a, MPUJEONHAIN b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8132460", Offset = "0x8131860", VA = "0x188132460")]
		private void JZNJZBTJIQR(ObjectLocalId a, MPUJEONHAIN b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8132660", Offset = "0x8131A60", VA = "0x188132660")]
		private void LSQTGMPYYEO(ObjectLocalId a, MPUJEONHAIN b, MPUJEONHAIN c, MPUJEONHAIN d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GWFUSAANFZB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FXDJFRICATK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public NAWAUUZVKFS container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public FXDJFRICATK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8127860", Offset = "0x8126C60", VA = "0x188127860")]
			internal OMConnectableManager RFSCJONULKB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8127A30", Offset = "0x8126E30", VA = "0x188127A30")]
		public static void WIOTHPQJFGR(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81279E0", Offset = "0x8126DE0", VA = "0x1881279E0")]
		public static void KEQFFLBHOQG(NAWAUUZVKFS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : FSKWOOTNMUJ, OBPQZCUEXSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager CXCZXHPIQOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly RKDWNJSHELB KSOYEHLTZHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly WWIZONGHVTP NLKAWVWHGGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly YEKOGYWUUHD[] TWYCRJGYXTX;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MPUJEONHAIN ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8137630", Offset = "0x8136A30", VA = "0x188137630", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MPUJEONHAIN YLUIXDRBUSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8136DD0", Offset = "0x81361D0", VA = "0x188136DD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 KBRRCHZCEAU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81372A0", Offset = "0x81366A0", VA = "0x1881372A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion TTJTBBUXEQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8136B30", Offset = "0x8135F30", VA = "0x188136B30", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BBSSRXQDUOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8136210", Offset = "0x8135610", VA = "0x188136210", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<MPUJEONHAIN> VLYUBHNHJSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8135AD0", Offset = "0x8134ED0", VA = "0x188135AD0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool PAIFPJJLUBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB70030", Offset = "0xB6F430", VA = "0x180B70030", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBB9E40", Offset = "0xBB9240", VA = "0x180BB9E40", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8137830", Offset = "0x8136C30", VA = "0x188137830", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8137550", Offset = "0x8136950", VA = "0x188137550", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8137570", Offset = "0x8136970", VA = "0x188137570", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8137690", Offset = "0x8136A90", VA = "0x188137690", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8137770", Offset = "0x8136B70", VA = "0x188137770", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool ZUQIJTAIUFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8136B90", Offset = "0x8135F90", VA = "0x188136B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler AIQKOYQBSIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8136890", Offset = "0x8135C90", VA = "0x188136890", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8136950", Offset = "0x8135D50", VA = "0x188136950", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler OUXOOVUTJUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8136840", Offset = "0x8135C40", VA = "0x188136840", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8135ED0", Offset = "0x81352D0", VA = "0x188135ED0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler OIGZMXKSFID
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x81368E0", Offset = "0x8135CE0", VA = "0x1881368E0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8135E80", Offset = "0x8135280", VA = "0x188135E80", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler RJZLLIGATDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8136A90", Offset = "0x8135E90", VA = "0x188136A90", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x81369F0", Offset = "0x8135DF0", VA = "0x1881369F0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8137450", Offset = "0x8136850", VA = "0x188137450")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, RKDWNJSHELB connectableTool, YEKOGYWUUHD[] connectionPoints, WWIZONGHVTP callbacks, FFKFPVCXATG connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8135AA0", Offset = "0x8134EA0", VA = "0x188135AA0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "21")]
		public void NPFQNGRJXKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8136590", Offset = "0x8135990", VA = "0x188136590", Slot = "22")]
		public void NTTBJUXLXRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81369A0", Offset = "0x8135DA0", VA = "0x1881369A0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8136630", Offset = "0x8135A30", VA = "0x188136630", Slot = "25")]
		public void OOXRDZCBVMQ(int a, MPUJEONHAIN b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8137300", Offset = "0x8136700", VA = "0x188137300", Slot = "26")]
		public void ZUVIBGYYSIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8135B00", Offset = "0x8134F00", VA = "0x188135B00", Slot = "27")]
		public void CFZFMIKJFXY(int a, MPUJEONHAIN b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81365B0", Offset = "0x81359B0", VA = "0x1881365B0", Slot = "28")]
		public void NWBXAUCPNAU(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8136E90", Offset = "0x8136290", VA = "0x188136E90", Slot = "31")]
		public void YSLKTBBREVP(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8136280", Offset = "0x8135680", VA = "0x188136280", Slot = "29")]
		public void NEVVOHMXOXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8136BE0", Offset = "0x8135FE0", VA = "0x188136BE0", Slot = "30")]
		public void XSWEMZRZTEM(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81360A0", Offset = "0x81354A0", VA = "0x1881360A0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8135F70", Offset = "0x8135370", VA = "0x188135F70", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCF3510", Offset = "0xCF2910", VA = "0x180CF3510", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8135DE0", Offset = "0x81351E0", VA = "0x188135DE0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, MPUJEONHAIN otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "44")]
		public void ParentChanged(int slotIndex, MPUJEONHAIN newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "45")]
		public void ChildAdded(int slotIndex, MPUJEONHAIN newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "46")]
		public void ChildRemoved(int slotIndex, MPUJEONHAIN removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "47")]
		public void ConnectionModified(int slotIndex, MPUJEONHAIN parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8136930", Offset = "0x8135D30", VA = "0x188136930", Slot = "48")]
		public void RootChanged(MPUJEONHAIN previousRootConnectable, MPUJEONHAIN newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81361C0", Offset = "0x81355C0", VA = "0x1881361C0", Slot = "23")]
		public void KTTESWTCYJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8135F20", Offset = "0x8135320", VA = "0x188135F20", Slot = "24")]
		public void DYYHXFPOKQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8136170", Offset = "0x8135570", VA = "0x188136170")]
		private void JJBXEAZTQWH(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(IRENMEBZLGU), new string[] { })]
	public class KSNIRGEOKMV : IRENMEBZLGU, CXEKRVIOQAN, MJITMAVCNAB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OMQYCOONSBK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public OMQYCOONSBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private YNTFXSUQWBO JCTAOMOJZPN;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object ENMLWYYCXTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8128F60", Offset = "0x8128360", VA = "0x188128F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8128F10", Offset = "0x8128310", VA = "0x188128F10", Slot = "5")]
		private void NWFIMGNSGYB(KHYDBENZVLP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC9B070", Offset = "0xC9A470", VA = "0x180C9B070", Slot = "6")]
		private void ILFOPVAQDXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KSNIRGEOKMV()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(FFKFPVCXATG), new string[] { "Ignore", "Mock" })]
	public class SJTLVPBJBIZ : FFKFPVCXATG, TQNNQAWTERF
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KZSKNTWAFUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool TCBTBFWIKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN> TBFHZMRBGWA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x81381F0", Offset = "0x81375F0", VA = "0x1881381F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8138090", Offset = "0x8137490", VA = "0x188138090", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN> NQQAIDSOTGK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8138140", Offset = "0x8137540", VA = "0x188138140", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8137F30", Offset = "0x8137330", VA = "0x188137F30", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN, MPUJEONHAIN> IOGVIWXIFSK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8137E80", Offset = "0x8137280", VA = "0x188137E80", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8137FE0", Offset = "0x81373E0", VA = "0x188137FE0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "26")]
		public void WKEWZWNCPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "12")]
		public void Initialize(GameObject gameObject, WGPTSJRFOJV configData, GRZXFGGAZBO rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "14")]
		public void MKOAUOREKWX(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "15")]
		public void VYJCJCEGTXK(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "16")]
		public void SKDIJZQJKPZ(MPUJEONHAIN a, HashSet<MPUJEONHAIN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "17")]
		public void RRDDCRMCRPZ(MPUJEONHAIN a, MPUJEONHAIN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "18")]
		public void AVYXLUPFTQZ(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "19")]
		public void YEDDWIZESVH(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "20")]
		public ConnectableGraphData OKQGMGVAWXS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "21")]
		public ConnectableGraphData IJESOXGVMQU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "22")]
		public bool ZDDYRTGJYEO(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "23")]
		public void BNLYPPNRWEB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "24")]
		public void HIFALGLCRDD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "25")]
		public void ZRHAJCKGFIS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SJTLVPBJBIZ()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MPUJEONHAIN : OBPQZCUEXSI, IEquatable<MPUJEONHAIN>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface OBPQZCUEXSI
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		MPUJEONHAIN ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Vector3 GetConnectionSlotLocalPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Vector3 GetConnectionSlotPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Color GetConnectionSlotColor(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool CanConnectTo(int slotIndex, MPUJEONHAIN otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, MPUJEONHAIN newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, MPUJEONHAIN newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, MPUJEONHAIN removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, MPUJEONHAIN parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(MPUJEONHAIN previousRootConnectable, MPUJEONHAIN newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FFKFPVCXATG : TQNNQAWTERF
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool KZSKNTWAFUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool TCBTBFWIKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<MPUJEONHAIN, MPUJEONHAIN> TBFHZMRBGWA;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<MPUJEONHAIN, MPUJEONHAIN> NQQAIDSOTGK;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<MPUJEONHAIN, MPUJEONHAIN, MPUJEONHAIN> IOGVIWXIFSK;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, WGPTSJRFOJV configData, GRZXFGGAZBO rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MKOAUOREKWX(MPUJEONHAIN a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void VYJCJCEGTXK(MPUJEONHAIN a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void SKDIJZQJKPZ(MPUJEONHAIN a, HashSet<MPUJEONHAIN> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void RRDDCRMCRPZ(MPUJEONHAIN a, MPUJEONHAIN b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AVYXLUPFTQZ(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void YEDDWIZESVH(MPUJEONHAIN a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData OKQGMGVAWXS(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData IJESOXGVMQU(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool ZDDYRTGJYEO(ZHLEOSYTUAE a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void BNLYPPNRWEB(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void HIFALGLCRDD(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ZRHAJCKGFIS(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NHUCTQIRRTC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MPUJEONHAIN FKMTYLWNYGK(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MPUJEONHAIN PWEXUWVKAYR(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WOTMKMOCLIV(MPUJEONHAIN a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YWTEJISKKTN();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OMRFGVLYKII(MPUJEONHAIN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WWIZONGHVTP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZUQIJTAIUFB(RKDWNJSHELB a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MGMKFWFLOUG(RKDWNJSHELB a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string JBNDGADVNEJ(RKDWNJSHELB a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid LHSMXOTJCMA(RKDWNJSHELB a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int TNCXAWHZUUV(RKDWNJSHELB a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RGACKRZBDUY(RKDWNJSHELB a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(MPUJEONHAIN childConnectable, int childConnectableSlot, MPUJEONHAIN parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(MPUJEONHAIN previousRootConnectable, MPUJEONHAIN newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface RKDWNJSHELB : MPUJEONHAIN, OBPQZCUEXSI, IEquatable<MPUJEONHAIN>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface FSKWOOTNMUJ : OBPQZCUEXSI
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		MPUJEONHAIN YLUIXDRBUSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<MPUJEONHAIN> VLYUBHNHJSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 KBRRCHZCEAU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion TTJTBBUXEQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool BBSSRXQDUOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool PAIFPJJLUBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler AIQKOYQBSIG;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler OUXOOVUTJUA;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler OIGZMXKSFID;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler RJZLLIGATDE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void NPFQNGRJXKQ();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void NTTBJUXLXRP();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void KTTESWTCYJA();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void DYYHXFPOKQZ();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void OOXRDZCBVMQ(int a, MPUJEONHAIN b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ZUVIBGYYSIU();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void CFZFMIKJFXY(int a, MPUJEONHAIN b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void NWBXAUCPNAU(MPUJEONHAIN a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void NEVVOHMXOXB();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void XSWEMZRZTEM(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void YSLKTBBREVP(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface YEKOGYWUUHD
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 FAGQNSESGVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface WGPTSJRFOJV
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool LOYKJIYDVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		BJVDDDIRAIM KGHBCUYKDPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, WGPTSJRFOJV
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LOYKJIYDVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF96C0", VA = "0x180BFA2C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BJVDDDIRAIM KGHBCUYKDPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8126D80", Offset = "0x8126180", VA = "0x188126D80")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8126E40", Offset = "0x8126240", VA = "0x188126E40")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MPUJEONHAIN connectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int parentSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8127380", Offset = "0x8126780", VA = "0x188127380")]
		public ConnectableLink(MPUJEONHAIN connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x81273E0", Offset = "0x81267E0", VA = "0x1881273E0")]
		public ConnectableLink(MPUJEONHAIN connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8127300", Offset = "0x8126700", VA = "0x188127300")]
		public ConnectableLink(MPUJEONHAIN connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8126E90", Offset = "0x8126290", VA = "0x188126E90", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8126F40", Offset = "0x8126340", VA = "0x188126F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : YDCHFVRYORS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform FSOLSSJPOTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private BJVDDDIRAIM GJXMIZHSACQ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A82F20", Offset = "0x7A82320", VA = "0x187A82F20", Slot = "4")]
		public void Initialize(Transform transform, BJVDDDIRAIM linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81292D0", Offset = "0x81286D0", VA = "0x1881292D0", Slot = "5")]
		public BJVDDDIRAIM KUCMDCEGVAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8129390", Offset = "0x8128790", VA = "0x188129390", Slot = "6")]
		public void SUGQXWJPRDG(BJVDDDIRAIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, QLUGWFCPANS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PJBPLOHLOXN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public MPUJEONHAIN KNXEAGIOTAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public MPUJEONHAIN LBVPVOOUFYS;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public PJBPLOHLOXN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8137850", Offset = "0x8136C50", VA = "0x188137850")]
			internal bool NWQIBKMOLXC(FTMRSRDFWNZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly OLGXLBTXHJO ESWLLGUVMUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private HDHGJHHQJDJ VPGJXEXFDSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ESNMTQYUQXX VIKZEIEJHSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool BXMKQQGJMQZ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log IISNFIRBEAD;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public FTMRSRDFWNZ TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x812A090", Offset = "0x8129490", VA = "0x18812A090")]
		public bool MPKADZQEUWR([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x812BF10", Offset = "0x812B310", VA = "0x18812BF10")]
		private bool UKVKHZZERZW([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x812CFA0", Offset = "0x812C3A0", VA = "0x18812CFA0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x812A630", Offset = "0x8129A30", VA = "0x18812A630", Slot = "5")]
		public void Initialize(FFKFPVCXATG manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x812A200", Offset = "0x8129600", VA = "0x18812A200", Slot = "17")]
		public void FVNZOCKRGPC(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x812CDA0", Offset = "0x812C1A0", VA = "0x18812CDA0", Slot = "12")]
		public void YCZHPTIRSAT(Func<MPUJEONHAIN, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x812CDB0", Offset = "0x812C1B0", VA = "0x18812CDB0")]
		private void YCZHPTIRSAT(OLGXLBTXHJO a, Func<MPUJEONHAIN, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x812C4C0", Offset = "0x812B8C0", VA = "0x18812C4C0", Slot = "11")]
		public void UPFZPANTDHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x812A230", Offset = "0x8129630", VA = "0x18812A230", Slot = "8")]
		public bool FWWBGTMTUMQ(MPUJEONHAIN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x812C6A0", Offset = "0x812BAA0", VA = "0x18812C6A0")]
		private bool XQFFFUKCLEF(MPUJEONHAIN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x812B880", Offset = "0x812AC80", VA = "0x18812B880")]
		private static bool SFSTCSIEOIX(MPUJEONHAIN a, OLGXLBTXHJO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x812A240", Offset = "0x8129640", VA = "0x18812A240")]
		private void HWZFFHUQNNV(Transform a, OLGXLBTXHJO b, OLGXLBTXHJO[] c, MPUJEONHAIN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x812A6E0", Offset = "0x8129AE0", VA = "0x18812A6E0")]
		private ConnectableLink KMGOPUUGMNE(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x812C4E0", Offset = "0x812B8E0", VA = "0x18812C4E0")]
		private static bool VMGHESFQZFL(OLGXLBTXHJO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x812BDE0", Offset = "0x812B1E0", VA = "0x18812BDE0", Slot = "9")]
		public bool TGEFNZVRXTS(MPUJEONHAIN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8129D30", Offset = "0x8129130", VA = "0x188129D30")]
		private bool AXZGQTPFDKR(MPUJEONHAIN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x812AE40", Offset = "0x812A240", VA = "0x18812AE40")]
		private static void PSJBMHXTEFC(MPUJEONHAIN a, int b, int c, Vector3 d, Quaternion e, OLGXLBTXHJO f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x812BCC0", Offset = "0x812B0C0", VA = "0x18812BCC0")]
		private void TARSCQDLJYB(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x812B030", Offset = "0x812A430", VA = "0x18812B030")]
		private void PUZICQKCTAR(OLGXLBTXHJO a, MPUJEONHAIN b, MPUJEONHAIN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x812AFC0", Offset = "0x812A3C0", VA = "0x18812AFC0")]
		private void PUZICQKCTAR(MPUJEONHAIN a, MPUJEONHAIN b, MPUJEONHAIN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x812A8D0", Offset = "0x8129CD0", VA = "0x18812A8D0")]
		private void LSQTGMPYYEO(MPUJEONHAIN a, MPUJEONHAIN b, MPUJEONHAIN c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x812A940", Offset = "0x8129D40", VA = "0x18812A940")]
		private void LSQTGMPYYEO(OLGXLBTXHJO a, MPUJEONHAIN b, MPUJEONHAIN c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8129C10", Offset = "0x8129010", VA = "0x188129C10")]
		private void AQJZETGNTGL(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x812A0A0", Offset = "0x81294A0", VA = "0x18812A0A0")]
		private void EPOVAYDNFFH(FTMRSRDFWNZ a, FTMRSRDFWNZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x812ACE0", Offset = "0x812A0E0", VA = "0x18812ACE0", Slot = "18")]
		public MPUJEONHAIN PIGPUNIZCKM(MPUJEONHAIN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x812B930", Offset = "0x812AD30", VA = "0x18812B930", Slot = "13")]
		public void SKDIJZQJKPZ(MPUJEONHAIN a, HashSet<MPUJEONHAIN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x812B0A0", Offset = "0x812A4A0", VA = "0x18812B0A0", Slot = "14")]
		public List<MPUJEONHAIN> QYYPMBVLBLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8129F80", Offset = "0x8129380", VA = "0x188129F80")]
		protected FTMRSRDFWNZ COJXWCBEUHW(FTMRSRDFWNZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x812A830", Offset = "0x8129C30", VA = "0x18812A830")]
		protected OLGXLBTXHJO[] KYJUSBSAFIN(OLGXLBTXHJO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x812ABD0", Offset = "0x8129FD0", VA = "0x18812ABD0")]
		protected bool NXHJHFSSPUQ(MPUJEONHAIN a, [Out] OLGXLBTXHJO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x812AA40", Offset = "0x8129E40", VA = "0x18812AA40", Slot = "15")]
		public bool MFFFQOMKDJC(MPUJEONHAIN a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x812A050", Offset = "0x8129450", VA = "0x18812A050")]
		protected OLGXLBTXHJO CRJVYXINXXD(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x812AB70", Offset = "0x8129F70", VA = "0x18812AB70", Slot = "10")]
		public bool MZKKEZVPNII(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x812B2E0", Offset = "0x812A6E0", VA = "0x18812B2E0")]
		private bool RXZXBPJXNAL(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x812BE40", Offset = "0x812B240", VA = "0x18812BE40")]
		private static bool TQNGAKXXTGJ(OLGXLBTXHJO a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x812A090", Offset = "0x8129490", VA = "0x18812A090", Slot = "7")]
		private bool DLDGAOWJZTK([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : FFKFPVCXATG, TQNNQAWTERF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly NAWAUUZVKFS container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly ESNMTQYUQXX VIKZEIEJHSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly NHDQCAHGDSW CZDLGJDITQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly YYGGJPUPAFW IRWMWPRFGSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly QLUGWFCPANS LSMBAQYENZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal EAVWXTLJPZL NLKAWVWHGGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal XSTAZNGTPNM THXJFJHLCRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal HDHGJHHQJDJ STMTEDCTTAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool BXMKQQGJMQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JAJWLPQUSOO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool YCZWBTJDYTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAEF4E0", Offset = "0xAEE8E0", VA = "0x180AEF4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAEEFE0", Offset = "0xAEE3E0", VA = "0x180AEEFE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KZSKNTWAFUV
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x10607D0", Offset = "0x105FBD0", VA = "0x1810607D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2538230", Offset = "0x2537630", VA = "0x182538230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool TCBTBFWIKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN> TBFHZMRBGWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x812EB10", Offset = "0x812DF10", VA = "0x18812EB10", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x812D440", Offset = "0x812C840", VA = "0x18812D440", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN> NQQAIDSOTGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x812E820", Offset = "0x812DC20", VA = "0x18812E820", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x812D380", Offset = "0x812C780", VA = "0x18812D380", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<MPUJEONHAIN, MPUJEONHAIN, MPUJEONHAIN> IOGVIWXIFSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x812D290", Offset = "0x812C690", VA = "0x18812D290", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x812D3E0", Offset = "0x812C7E0", VA = "0x18812D3E0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x812EDE0", Offset = "0x812E1E0", VA = "0x18812EDE0")]
		public LegacyConnectableManager(NAWAUUZVKFS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x812D750", Offset = "0x812CB50", VA = "0x18812D750", Slot = "12")]
		public void Initialize(GameObject gameObject, WGPTSJRFOJV configData, GRZXFGGAZBO rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x812E880", Offset = "0x812DC80", VA = "0x18812E880", Slot = "26")]
		public void WKEWZWNCPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x812E7A0", Offset = "0x812DBA0", VA = "0x18812E7A0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x812DE60", Offset = "0x812D260", VA = "0x18812DE60", Slot = "14")]
		public void MKOAUOREKWX(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x812D550", Offset = "0x812C950", VA = "0x18812D550", Slot = "15")]
		public void VYJCJCEGTXK(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x812ED50", Offset = "0x812E150", VA = "0x18812ED50", Slot = "22")]
		public bool ZDDYRTGJYEO(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x812E5A0", Offset = "0x812D9A0", VA = "0x18812E5A0")]
		internal bool RXZXBPJXNAL([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x812DD10", Offset = "0x812D110", VA = "0x18812DD10")]
		internal bool JVWPIIQDZCZ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x812EB70", Offset = "0x812DF70", VA = "0x18812EB70")]
		internal void YXNEWTLDBRP(MPUJEONHAIN a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x812D550", Offset = "0x812C950", VA = "0x18812D550")]
		internal bool HRDHRSFTBZL(MPUJEONHAIN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x812E0D0", Offset = "0x812D4D0", VA = "0x18812E0D0")]
		internal bool OJKERXTDQZV(MPUJEONHAIN a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x812E6B0", Offset = "0x812DAB0", VA = "0x18812E6B0", Slot = "16")]
		public void SKDIJZQJKPZ(MPUJEONHAIN a, HashSet<MPUJEONHAIN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x812E390", Offset = "0x812D790", VA = "0x18812E390", Slot = "17")]
		public void RRDDCRMCRPZ(MPUJEONHAIN a, MPUJEONHAIN b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x812D150", Offset = "0x812C550", VA = "0x18812D150", Slot = "18")]
		public void AVYXLUPFTQZ(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x812E950", Offset = "0x812DD50", VA = "0x18812E950", Slot = "19")]
		public void YEDDWIZESVH(MPUJEONHAIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x812DE80", Offset = "0x812D280", VA = "0x18812DE80")]
		public void OIXNUBURSAA([Optional] JDMCEZTJJPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x812D2F0", Offset = "0x812C6F0", VA = "0x18812D2F0", Slot = "23")]
		public void BNLYPPNRWEB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x812E210", Offset = "0x812D610", VA = "0x18812E210", Slot = "20")]
		public ConnectableGraphData OKQGMGVAWXS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x812D5B0", Offset = "0x812C9B0", VA = "0x18812D5B0", Slot = "21")]
		public ConnectableGraphData IJESOXGVMQU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x812EDA0", Offset = "0x812E1A0", VA = "0x18812EDA0", Slot = "25")]
		public void ZRHAJCKGFIS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x812D4A0", Offset = "0x812C8A0", VA = "0x18812D4A0", Slot = "24")]
		public void HIFALGLCRDD(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ESNMTQYUQXX : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly JQXQLJXAXIC<MPUJEONHAIN, MPUJEONHAIN> TBFHZMRBGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly JQXQLJXAXIC<MPUJEONHAIN, MPUJEONHAIN> NQQAIDSOTGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly JRCXIQQYGTL<MPUJEONHAIN, MPUJEONHAIN, MPUJEONHAIN> IOGVIWXIFSK;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8127700", Offset = "0x8126B00", VA = "0x188127700")]
		public ESNMTQYUQXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x81275C0", Offset = "0x81269C0", VA = "0x1881275C0")]
		public void AVMKBMWWRCY(MPUJEONHAIN a, MPUJEONHAIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8127620", Offset = "0x8126A20", VA = "0x188127620")]
		public void CXLZQRLYRTU(MPUJEONHAIN a, MPUJEONHAIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8127680", Offset = "0x8126A80", VA = "0x188127680")]
		public void OUFSKVMRVEK(MPUJEONHAIN a, MPUJEONHAIN b, MPUJEONHAIN c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class NHDQCAHGDSW : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager HQTUECNYSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private XSTAZNGTPNM THXJFJHLCRO;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public NHDQCAHGDSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8130380", Offset = "0x812F780", VA = "0x188130380")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8130270", Offset = "0x812F670", VA = "0x188130270", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8130520", Offset = "0x812F920", VA = "0x188130520")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x81304B0", Offset = "0x812F8B0", VA = "0x1881304B0")]
		private void OnMasterClientSwitched(JDMCEZTJJPL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8130280", Offset = "0x812F680", VA = "0x188130280")]
		public void IWYYWPMBKSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8130170", Offset = "0x812F570", VA = "0x188130170")]
		public void DFCIVJEPRVL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class LNOHRFHLUNS
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class FXDJFRICATK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public NAWAUUZVKFS container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public FXDJFRICATK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8127800", Offset = "0x8126C00", VA = "0x188127800")]
			internal LegacyConnectableManager RFSCJONULKB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x81290E0", Offset = "0x81284E0", VA = "0x1881290E0")]
		public static void WIOTHPQJFGR(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8129060", Offset = "0x8128460", VA = "0x188129060")]
		public static void KEQFFLBHOQG(NAWAUUZVKFS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, HDHGJHHQJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, BJVDDDIRAIM> JTPKTCHVIYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation KLQRQSEDSCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private YDCHFVRYORS EZWIWTXFXBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private QLUGWFCPANS LSMBAQYENZM;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker RYTSAQXWNHS;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x812FDD0", Offset = "0x812F1D0", VA = "0x18812FDD0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x812F670", Offset = "0x812EA70", VA = "0x18812F670", Slot = "7")]
		public void Initialize(QLUGWFCPANS graph, YDCHFVRYORS creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x812F870", Offset = "0x812EC70", VA = "0x18812F870", Slot = "5")]
		public void SDMOXRTGGAF(FTMRSRDFWNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x812FC00", Offset = "0x812F000", VA = "0x18812FC00", Slot = "9")]
		public void VTGSPSRHEUQ(FTMRSRDFWNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x812F6B0", Offset = "0x812EAB0", VA = "0x18812F6B0", Slot = "8")]
		public void JTZCWVDFZIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x812F320", Offset = "0x812E720", VA = "0x18812F320", Slot = "10")]
		public void BXFGHAUKMEL(FTMRSRDFWNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x812FAB0", Offset = "0x812EEB0", VA = "0x18812FAB0", Slot = "11")]
		public void SXRXYVSKWFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x812F170", Offset = "0x812E570", VA = "0x18812F170")]
		private bool ABTIYYCVOKS(FTMRSRDFWNZ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class YYGGJPUPAFW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly OLGXLBTXHJO currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly ZHLEOSYTUAE parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly ZHLEOSYTUAE rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool ALHVJQVBSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x81382A0", Offset = "0x81376A0", VA = "0x1881382A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8138B40", Offset = "0x8137F40", VA = "0x188138B40")]
			public SerializeNodeInSubgraph(OLGXLBTXHJO currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] ZHLEOSYTUAE parentNodeData, [Optional] ZHLEOSYTUAE rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x81383B0", Offset = "0x81377B0", VA = "0x1881383B0")]
			public ZHLEOSYTUAE MFMKHXDBDDO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8138750", Offset = "0x8137B50", VA = "0x188138750")]
			private ZHLEOSYTUAE ULAIVQFUZEQ([Out] ZHLEOSYTUAE a, [Out] ZHLEOSYTUAE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8138550", Offset = "0x8137950", VA = "0x188138550")]
			private ZHLEOSYTUAE OCSZUFTDVEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8138810", Offset = "0x8137C10", VA = "0x188138810")]
			private void UVNYLNWHYQO(ZHLEOSYTUAE a, ZHLEOSYTUAE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8138980", Offset = "0x8137D80", VA = "0x188138980")]
			private void XRPYQVPUPWX(ZHLEOSYTUAE a, ZHLEOSYTUAE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager HQTUECNYSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private QLUGWFCPANS LSMBAQYENZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private HDHGJHHQJDJ VPGJXEXFDSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private XSTAZNGTPNM THXJFJHLCRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool NFBWBJFZCAW;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool JYBUCYEFSDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x81396D0", Offset = "0x8138AD0", VA = "0x1881396D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool YCZWBTJDYTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x813AD10", Offset = "0x813A110", VA = "0x18813AD10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x813A290", Offset = "0x8139690", VA = "0x18813A290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8139DD0", Offset = "0x81391D0", VA = "0x188139DD0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x813A120", Offset = "0x8139520", VA = "0x18813A120")]
		public ConnectableGraphData OKQGMGVAWXS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8139C00", Offset = "0x8139000", VA = "0x188139C00")]
		public ConnectableGraphData IJESOXGVMQU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8139300", Offset = "0x8138700", VA = "0x188139300")]
		public void BNLYPPNRWEB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8139B60", Offset = "0x8138F60", VA = "0x188139B60")]
		public void HIFALGLCRDD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8139DA0", Offset = "0x81391A0", VA = "0x188139DA0")]
		public void IZIOXJCGDZB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x81398A0", Offset = "0x8138CA0", VA = "0x1881398A0")]
		private void HBJGEPFEDFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8139A80", Offset = "0x8138E80", VA = "0x188139A80")]
		private ZHLEOSYTUAE HBSDOXOWUEO(OLGXLBTXHJO a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x813AE40", Offset = "0x813A240", VA = "0x18813AE40")]
		private static void YJUUJDMSHGM(OLGXLBTXHJO a, bool b, ZHLEOSYTUAE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8138DB0", Offset = "0x81381B0", VA = "0x188138DB0")]
		private void ADZOSWTFGTF(OLGXLBTXHJO a, bool b, ZHLEOSYTUAE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8139270", Offset = "0x8138670", VA = "0x188139270")]
		private ZHLEOSYTUAE BKEOWYUNOZE(OLGXLBTXHJO a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8138FD0", Offset = "0x81383D0", VA = "0x188138FD0")]
		private bool AGWDCJZFJEU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x813A440", Offset = "0x8139840", VA = "0x18813A440")]
		private bool UNNUJKKILUZ(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8139250", Offset = "0x8138650", VA = "0x188139250")]
		private bool ASPPEEOZMGD(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x813AD30", Offset = "0x813A130", VA = "0x18813AD30")]
		private static bool XZGKQLYEXDM(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x813B0F0", Offset = "0x813A4F0", VA = "0x18813B0F0")]
		public static bool ZDDYRTGJYEO(ZHLEOSYTUAE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8139390", Offset = "0x8138790", VA = "0x188139390")]
		private MPUJEONHAIN CZUKRGMFNMA(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8139720", Offset = "0x8138B20", VA = "0x188139720")]
		private MPUJEONHAIN FKMTYLWNYGK(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x813A2B0", Offset = "0x81396B0", VA = "0x18813A2B0")]
		private MPUJEONHAIN SFDJCGLLMQJ(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8131F30", Offset = "0x8131330", VA = "0x188131F30")]
		private static Guid IBKPXTEBLFF(ZHLEOSYTUAE a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8139E40", Offset = "0x8139240", VA = "0x188139E40")]
		private string JHKWYEMBQPU(ZHLEOSYTUAE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8139F30", Offset = "0x8139330", VA = "0x188139F30")]
		private bool LMSNWIKSFAV(OLGXLBTXHJO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x813AAB0", Offset = "0x8139EB0", VA = "0x18813AAB0")]
		private static void VASFCYKFDWN(OLGXLBTXHJO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public YYGGJPUPAFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public MPUJEONHAIN child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public MPUJEONHAIN parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int childSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int parentSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ConnectableLink TZOEGILMULK
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8127480", Offset = "0x8126880", VA = "0x188127480")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink WJQKHIKSZFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8127520", Offset = "0x8126920", VA = "0x188127520")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8127550", Offset = "0x8126950", VA = "0x188127550")]
		public ConnectionOperationData(MPUJEONHAIN child, MPUJEONHAIN parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface QLUGWFCPANS
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		FTMRSRDFWNZ TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(FFKFPVCXATG manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MPKADZQEUWR([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FWWBGTMTUMQ(MPUJEONHAIN a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TGEFNZVRXTS(MPUJEONHAIN a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MZKKEZVPNII(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UPFZPANTDHR();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YCZHPTIRSAT(Func<MPUJEONHAIN, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SKDIJZQJKPZ(MPUJEONHAIN a, HashSet<MPUJEONHAIN> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<MPUJEONHAIN> QYYPMBVLBLB();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool MFFFQOMKDJC(MPUJEONHAIN a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void FVNZOCKRGPC(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(FTMRSRDFWNZ node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface FTMRSRDFWNZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		MPUJEONHAIN WDAQELEUSFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		FTMRSRDFWNZ LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink BLQPTHYOTVM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool TMCUDLOYZNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface BJVDDDIRAIM : JEOQNIGYCZC.HRRNKNRWEJU
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HGSJECSPXBK(MPUJEONHAIN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RMEIEFDGFHG(MPUJEONHAIN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IMVYMTAKCAJ(MPUJEONHAIN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WZCSHVRCOML(MPUJEONHAIN a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		BJVDDDIRAIM MPJKFUYYEDU(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface YDCHFVRYORS
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, BJVDDDIRAIM linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BJVDDDIRAIM KUCMDCEGVAG();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SUGQXWJPRDG(BJVDDDIRAIM a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface EAVWXTLJPZL : NHUCTQIRRTC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool APSQUNTNLXJ();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SXDVQEUCJBA(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface HDHGJHHQJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SDMOXRTGGAF(FTMRSRDFWNZ a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(QLUGWFCPANS graph, YDCHFVRYORS linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JTZCWVDFZIK();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VTGSPSRHEUQ(FTMRSRDFWNZ a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BXFGHAUKMEL(FTMRSRDFWNZ a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SXRXYVSKWFV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class OLGXLBTXHJO : FTMRSRDFWNZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class MLPLZXSSYAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink QIYQAUCSPXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public OLGXLBTXHJO QIMGPCZANKC;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MLPLZXSSYAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8130030", Offset = "0x812F430", VA = "0x188130030")]
			internal bool WUEDHORWLLL(FTMRSRDFWNZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink NDWZNXEVANQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<OLGXLBTXHJO> RUHBADOSRLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private OLGXLBTXHJO SXWAIWKZMTR;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink BLQPTHYOTVM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x478C4B0", Offset = "0x478B8B0", VA = "0x18478C4B0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8130560", Offset = "0x812F960", VA = "0x188130560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private OLGXLBTXHJO ZXFWECNPPKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x81309B0", Offset = "0x812FDB0", VA = "0x1881309B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FTMRSRDFWNZ LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public MPUJEONHAIN WDAQELEUSFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool TMCUDLOYZNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8130C10", Offset = "0x8130010", VA = "0x188130C10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NJQZHTRLQMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8130960", Offset = "0x812FD60", VA = "0x188130960", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected OLGXLBTXHJO BRWFJBTAWNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8130590", Offset = "0x812F990", VA = "0x188130590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8130FF0", Offset = "0x81303F0", VA = "0x188130FF0")]
		public OLGXLBTXHJO(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8130EB0", Offset = "0x81302B0", VA = "0x188130EB0")]
		public OLGXLBTXHJO SSSGUVRVYSN(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8130A90", Offset = "0x812FE90", VA = "0x188130A90")]
		public OLGXLBTXHJO LLKZFVWFTQB(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8130C20", Offset = "0x8130020", VA = "0x188130C20")]
		public OLGXLBTXHJO Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x81306A0", Offset = "0x812FAA0", VA = "0x1881306A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8130E00", Offset = "0x8130200", VA = "0x188130E00")]
		public OLGXLBTXHJO Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8130800", Offset = "0x812FC00", VA = "0x188130800")]
		private static void FVNZOCKRGPC(OLGXLBTXHJO a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x81307F0", Offset = "0x812FBF0", VA = "0x1881307F0", Slot = "9")]
		public void FVNZOCKRGPC(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x81305B0", Offset = "0x812F9B0", VA = "0x1881305B0")]
		public static OLGXLBTXHJO CRJVYXINXXD(OLGXLBTXHJO a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface XSTAZNGTPNM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool JYBUCYEFSDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> SWFVAOYCIID;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<JDMCEZTJJPL> XRWHMBXWAPF;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HGSJECSPXBK(LegacyConnectableManager a, GRZXFGGAZBO b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RRDDCRMCRPZ(MPUJEONHAIN a, MPUJEONHAIN b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AVYXLUPFTQZ(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GPCOKUBXHQI(ConnectableGraphData a, [Optional] JDMCEZTJJPL b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class FZNUEPTKRXG
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8127900", Offset = "0x8126D00", VA = "0x188127900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8127950", Offset = "0x8126D50", VA = "0x188127950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8127990", Offset = "0x8126D90", VA = "0x188127990")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class HGLXUTEYXVF : XSTAZNGTPNM, IDisposable, HEGIQPROIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager HQTUECNYSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private GRZXFGGAZBO LAAZSOUINVC;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JYBUCYEFSDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8127DA0", Offset = "0x81271A0", VA = "0x188127DA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x81289F0", Offset = "0x8127DF0", VA = "0x1881289F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView JWMKMICKLDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8127CC0", Offset = "0x81270C0", VA = "0x188127CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> SWFVAOYCIID
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8128A30", Offset = "0x8127E30", VA = "0x188128A30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8128050", Offset = "0x8127450", VA = "0x188128050", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JDMCEZTJJPL> XRWHMBXWAPF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8127FB0", Offset = "0x81273B0", VA = "0x188127FB0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x81280E0", Offset = "0x81274E0", VA = "0x1881280E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8127F20", Offset = "0x8127320", VA = "0x188127F20", Slot = "10")]
		public void HGSJECSPXBK(LegacyConnectableManager a, GRZXFGGAZBO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8127D50", Offset = "0x8127150", VA = "0x188127D50", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8128180", Offset = "0x8127580", VA = "0x188128180", Slot = "11")]
		public void RRDDCRMCRPZ(MPUJEONHAIN a, MPUJEONHAIN b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8127BA0", Offset = "0x8126FA0", VA = "0x188127BA0", Slot = "12")]
		public void AVYXLUPFTQZ(MPUJEONHAIN a, int b, MPUJEONHAIN c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8127E00", Offset = "0x8127200", VA = "0x188127E00", Slot = "13")]
		public void GPCOKUBXHQI(ConnectableGraphData a, [Optional] JDMCEZTJJPL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x81284D0", Offset = "0x81278D0", VA = "0x1881284D0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(MPUJEONHAIN objectToReparent, int objectToReparentSlotIndex, MPUJEONHAIN newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x81282E0", Offset = "0x81276E0", VA = "0x1881282E0")]
		[RPCMethod]
		private void RpcMasterModifyNode(MPUJEONHAIN connectableToModify, MPUJEONHAIN expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x81288C0", Offset = "0x8127CC0", VA = "0x1881288C0")]
		[RPCMethod]
		private void RpcReparentNodes(MPUJEONHAIN objectToReparent, int objectToReparentSlotIndex, MPUJEONHAIN newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x81287D0", Offset = "0x8127BD0", VA = "0x1881287D0")]
		[RPCMethod]
		private void RpcModifyNode(MPUJEONHAIN connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x81282A0", Offset = "0x81276A0", VA = "0x1881282A0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public HGLXUTEYXVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, BJVDDDIRAIM, JEOQNIGYCZC.HRRNKNRWEJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8129A30", Offset = "0x8128E30", VA = "0x188129A30", Slot = "4")]
		private void SSZCAKMZHAL(MPUJEONHAIN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8129750", Offset = "0x8128B50", VA = "0x188129750", Slot = "5")]
		private void HUYRCMRNJTJ(MPUJEONHAIN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8129400", Offset = "0x8128800", VA = "0x188129400", Slot = "6")]
		private void BWDIYZZKJSI(MPUJEONHAIN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8129560", Offset = "0x8128960", VA = "0x188129560", Slot = "7")]
		private void CYNTWIUCKNS(MPUJEONHAIN a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x81299C0", Offset = "0x8128DC0", VA = "0x1881299C0", Slot = "8")]
		private BJVDDDIRAIM JAKAHEJXXKH(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8129BB0", Offset = "0x8128FB0", VA = "0x188129BB0", Slot = "9")]
		private void TUHTHZEVZUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class BGOHKXHKWWK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x33B24F0", Offset = "0x33B18F0", VA = "0x1833B24F0")]
		public static XCXSFAAYUCJ<a> XDZIWXJFIOU<a>(this NAWAUUZVKFS a)
		{
			return null;
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
