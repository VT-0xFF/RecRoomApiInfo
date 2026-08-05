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
		[Cpp2IlInjected.Address(RVA = "0x98D5050", Offset = "0x98D3A50", VA = "0x1898D5050", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private int[] YLRGDEQABQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] YLWNALJXLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset KVULHZCLSVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset KVPEKSIOJKC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x226C780", Offset = "0x226B180", VA = "0x18226C780", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98E0D50", Offset = "0x98DF750", VA = "0x1898E0D50")]
		private void AWUQDEJRHIB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98E0C00", Offset = "0x98DF600", VA = "0x1898E0C00")]
		private void AWPJFXPTXWS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98E0EA0", Offset = "0x98DF8A0", VA = "0x1898E0EA0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98E11B0", Offset = "0x98DFBB0", VA = "0x1898E11B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : BYHNCOWWIKU, PLILCFKSRWT
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MMYIYBVVZOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OFXQUQYPCHS UDNIXOWNCZQ;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MMYIYBVVZOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x98D51E0", Offset = "0x98D3BE0", VA = "0x1898D51E0")]
			internal object VUBXPFUYPJL(OFXQUQYPCHS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MNDPVIPTIZT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OFXQUQYPCHS XPPBUWYUJUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MMYIYBVVZOK UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MNDPVIPTIZT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98D5250", Offset = "0x98D3C50", VA = "0x1898D5250")]
			internal object VTWQRZBBFYC((OFXQUQYPCHS child, OFXQUQYPCHS nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CTMTPFZVIVT : IEnumerable<AMFBTRVCLRD>, IEnumerable, IEnumerator<AMFBTRVCLRD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private AMFBTRVCLRD RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId HCLQNCMZLIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId GLORCXKNQSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private DPCIRWPKBDP UKXXGEIOBVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray LXYGBXRZXXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator IQUZHIRIGZW;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private AMFBTRVCLRD QRTFNJSFWSL
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public CTMTPFZVIVT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x98CC530", Offset = "0x98CAF30", VA = "0x1898CC530", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x98CC650", Offset = "0x98CB050", VA = "0x1898CC650", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x98CCA60", Offset = "0x98CB460", VA = "0x1898CCA60")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x98CCA80", Offset = "0x98CB480", VA = "0x1898CCA80")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x98CC610", Offset = "0x98CB010", VA = "0x1898CC610", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x98CC9B0", Offset = "0x98CB3B0", VA = "0x1898CC9B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AMFBTRVCLRD> ZWVYYOKLDCI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x98CC9B0", Offset = "0x98CB3B0", VA = "0x1898CC9B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log KGDAOOYMUSZ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log HZJNBRGWEDP;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log YHHWPPSMYRD;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log EEAAQLBGTLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OVALCAWBIRW BOKXNXUGUCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EKWYZQNUAJB EAYEHPCMKXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private QHWUXONNTBA UOIIRNMQNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ZMYNXIZYVSI XYPHPWBDKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private DQLWGWQLTQA NCDQPBCHAJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NCVUHSJQCVS XTLGDYSPKHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly BMWDXFSNYIN YLPAGZLMABY;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD15970", Offset = "0xD14370", VA = "0x180D15970", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD15930", Offset = "0xD14330", VA = "0x180D15930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QETWNCSRYPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD> HKJZGTGQFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x98D8650", Offset = "0x98D7050", VA = "0x1898D8650", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x98D6910", Offset = "0x98D5310", VA = "0x1898D6910", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD> QLUEWNQWZXU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98D7FB0", Offset = "0x98D69B0", VA = "0x1898D7FB0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98DA7C0", Offset = "0x98D91C0", VA = "0x1898DA7C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD, AMFBTRVCLRD> OWVDXOWEJFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x98D6550", Offset = "0x98D4F50", VA = "0x1898D6550", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x98D6600", Offset = "0x98D5000", VA = "0x1898D6600", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98DAE10", Offset = "0x98D9810", VA = "0x1898DAE10")]
		public OMConnectableManager(ZUKUOYIIEVW container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98D77F0", Offset = "0x98D61F0", VA = "0x1898D77F0", Slot = "12")]
		public void Initialize(GameObject gameObject, NSZOVVNPIJR configData, RWZZUAKIDOQ sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98D8480", Offset = "0x98D6E80", VA = "0x1898D8480", Slot = "26")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98D7050", Offset = "0x98D5A50", VA = "0x1898D7050", Slot = "22")]
		public bool DAZVTTVWQRQ(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98D9910", Offset = "0x98D8310", VA = "0x1898D9910")]
		private void VFWAMDHFTPB(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98D8700", Offset = "0x98D7100", VA = "0x1898D8700")]
		private void PMHBHWQTEXH(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98D66B0", Offset = "0x98D50B0", VA = "0x1898D66B0")]
		private void CPETHVRBVFR(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98D9D30", Offset = "0x98D8730", VA = "0x1898D9D30")]
		private void WMKQITZMRLC(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98DA140", Offset = "0x98D8B40", VA = "0x1898DA140", Slot = "14")]
		public void WSFSWRIEDET(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "15")]
		public void QNRHIMHGGAQ(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98D70A0", Offset = "0x98D5AA0", VA = "0x1898D70A0", Slot = "17")]
		public void FQGPVTEZGIP(AMFBTRVCLRD a, AMFBTRVCLRD b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98D7200", Offset = "0x98D5C00", VA = "0x1898D7200")]
		public void FQGPVTEZGIP(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98D76D0", Offset = "0x98D60D0", VA = "0x1898D76D0")]
		public void GIUVCRWNQUJ(AMFBTRVCLRD a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98DAA00", Offset = "0x98D9400", VA = "0x1898DAA00", Slot = "18")]
		public void ZWDFORZDSEJ(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98DA450", Offset = "0x98D8E50", VA = "0x1898DA450")]
		private float WVIMGZQEGWD(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98DAB60", Offset = "0x98D9560", VA = "0x1898DAB60")]
		public void ZWDFORZDSEJ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98D63E0", Offset = "0x98D4DE0", VA = "0x1898D63E0", Slot = "19")]
		public void AHATMLBGFTD(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98D9B20", Offset = "0x98D8520", VA = "0x1898D9B20", Slot = "16")]
		public void VYQYATCDLVN(AMFBTRVCLRD a, HashSet<AMFBTRVCLRD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "20")]
		public ConnectableGraphData WITHAKROGEE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "21")]
		public ConnectableGraphData WEABRPHIXSI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98D7780", Offset = "0x98D6180", VA = "0x1898D7780", Slot = "23")]
		public void HRPPHYETQDH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98D74D0", Offset = "0x98D5ED0", VA = "0x1898D74D0", Slot = "24")]
		public void GEZDJQGMVKB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98D7760", Offset = "0x98D6160", VA = "0x1898D7760", Slot = "25")]
		public void GNVHGTCNLIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98D69C0", Offset = "0x98D53C0", VA = "0x1898D69C0")]
		private void CWMUTETNIFH(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98D8FB0", Offset = "0x98D79B0", VA = "0x1898D8FB0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98D98A0", Offset = "0x98D82A0", VA = "0x1898D98A0")]
		private void TYKLQWIEJFE(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98D7F20", Offset = "0x98D6920", VA = "0x1898D7F20")]
		[IteratorStateMachine(typeof(CTMTPFZVIVT))]
		public IEnumerable<AMFBTRVCLRD> KUZZYTJXMPN(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98D7DF0", Offset = "0x98D67F0", VA = "0x1898D7DF0")]
		internal AMFBTRVCLRD KHNELERIYNO(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98D7540", Offset = "0x98D5F40", VA = "0x1898D7540")]
		internal ObjectLocalId GFOWUBEVEOA(AMFBTRVCLRD a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98D8920", Offset = "0x98D7320", VA = "0x1898D8920")]
		private bool RGSYRVYONAV(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98D83C0", Offset = "0x98D6DC0", VA = "0x1898D83C0")]
		private bool NYIUFSKUZMF(OFXQUQYPCHS a, [Out] AMFBTRVCLRD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98D7A60", Offset = "0x98D6460", VA = "0x1898D7A60")]
		private AMFBTRVCLRD KHNELERIYNO(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98D7340", Offset = "0x98D5D40", VA = "0x1898D7340")]
		private AMFBTRVCLRD FWAAQXHQQLH(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98D8060", Offset = "0x98D6A60", VA = "0x1898D8060")]
		private AMFBTRVCLRD MGNWNHBEQTE(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98DA780", Offset = "0x98D9180", VA = "0x1898DA780")]
		private static Guid YTQAYFZVJBZ(OFXQUQYPCHS a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98DA500", Offset = "0x98D8F00", VA = "0x1898DA500")]
		private string XCWBKNDFRJI(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98D8230", Offset = "0x98D6C30", VA = "0x1898D8230")]
		private void NNKRUWIBHXP(AMFBTRVCLRD a, AMFBTRVCLRD b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98DA870", Offset = "0x98D9270", VA = "0x1898DA870")]
		private void ZSTPAXICWOD(AMFBTRVCLRD a, AMFBTRVCLRD b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98D8420", Offset = "0x98D6E20", VA = "0x1898D8420")]
		private void OKGKXUYOKSV(AMFBTRVCLRD a, AMFBTRVCLRD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98DA5F0", Offset = "0x98D8FF0", VA = "0x1898DA5F0")]
		private void YHJOFVKEGRW(AMFBTRVCLRD a, AMFBTRVCLRD b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98D8EA0", Offset = "0x98D78A0", VA = "0x1898D8EA0")]
		private void SRVGSRSQPFP(ObjectLocalId a, AMFBTRVCLRD b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98D6DD0", Offset = "0x98D57D0", VA = "0x1898D6DD0")]
		private void CYADXUQAEDU(ObjectLocalId a, AMFBTRVCLRD b, AMFBTRVCLRD c, AMFBTRVCLRD d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class UPPOIOSLRZN
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public ZUKUOYIIEVW container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x98CDF70", Offset = "0x98CC970", VA = "0x1898CDF70")]
			internal OMConnectableManager GINIITLJCYV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98E0130", Offset = "0x98DEB30", VA = "0x1898E0130")]
		public static void UUWEQCKEXAR(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98E00E0", Offset = "0x98DEAE0", VA = "0x1898E00E0")]
		public static void MIAVWPVSRMO(ZUKUOYIIEVW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : WWBUOLOKJMR, WCDYBXKQGKY
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager WWSADOMJBGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly JXOUTCQTCDN VSCNVNEWMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly CUEYMGZMWEF XYPHPWBDKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly GDEEYQAJWUN[] NTVBLWBQZSV;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AMFBTRVCLRD ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x98DCA30", Offset = "0x98DB430", VA = "0x1898DCA30", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AMFBTRVCLRD NTLSLIVWAPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x98DAF60", Offset = "0x98D9960", VA = "0x1898DAF60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 JCOMCCGNQXS
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x98DB300", Offset = "0x98D9D00", VA = "0x1898DB300", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion OIKPFTNIGFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x98DAE80", Offset = "0x98D9880", VA = "0x1898DAE80", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool QSCNVGFGAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x98DC0C0", Offset = "0x98DAAC0", VA = "0x1898DC0C0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<AMFBTRVCLRD> WLVXWKYYQDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x98DC780", Offset = "0x98DB180", VA = "0x1898DC780", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool LBZNBWIDOMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E60", Offset = "0xDB4860", VA = "0x180DB5E60", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xEAB150", Offset = "0xEA9B50", VA = "0x180EAB150", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98DCC40", Offset = "0x98DB640", VA = "0x1898DCC40", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98DC940", Offset = "0x98DB340", VA = "0x1898DC940", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98DC960", Offset = "0x98DB360", VA = "0x1898DC960", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x98DCA90", Offset = "0x98DB490", VA = "0x1898DCA90", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x98DCB70", Offset = "0x98DB570", VA = "0x1898DCB70", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KKEKQWARIXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x98DAF10", Offset = "0x98D9910", VA = "0x1898DAF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler ORMPAASXSQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x98DC240", Offset = "0x98DAC40", VA = "0x1898DC240", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x98DB900", Offset = "0x98DA300", VA = "0x1898DB900", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler YRBXCNVXMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x98DB2B0", Offset = "0x98D9CB0", VA = "0x1898DB2B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x98DC6E0", Offset = "0x98DB0E0", VA = "0x1898DC6E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler WFFTGWLPWED
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x98DC130", Offset = "0x98DAB30", VA = "0x1898DC130", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x98DC070", Offset = "0x98DAA70", VA = "0x1898DC070", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler JKYIBEOBTDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x98DC5C0", Offset = "0x98DAFC0", VA = "0x1898DC5C0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x98DB860", Offset = "0x98DA260", VA = "0x1898DB860", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x98DC840", Offset = "0x98DB240", VA = "0x1898DC840")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, JXOUTCQTCDN connectableTool, GDEEYQAJWUN[] connectionPoints, CUEYMGZMWEF callbacks, BYHNCOWWIKU connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98DAEE0", Offset = "0x98D98E0", VA = "0x1898DAEE0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "21")]
		public void MKLPGREUVAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x98DB630", Offset = "0x98DA030", VA = "0x1898DB630", Slot = "22")]
		public void LAIGKNPAYFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98DC1F0", Offset = "0x98DABF0", VA = "0x1898DC1F0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98DB650", Offset = "0x98DA050", VA = "0x1898DB650", Slot = "25")]
		public void LJTDVGWKNFC(int a, AMFBTRVCLRD b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98DB560", Offset = "0x98D9F60", VA = "0x1898DB560", Slot = "26")]
		public void HMOWVOFOGJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98DC2E0", Offset = "0x98DACE0", VA = "0x1898DC2E0", Slot = "27")]
		public void WFLJWSKDNLU(int a, AMFBTRVCLRD b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98DC660", Offset = "0x98DB060", VA = "0x1898DC660", Slot = "28")]
		public void YJCQJBHOJOM(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98DB950", Offset = "0x98DA350", VA = "0x1898DB950", Slot = "31")]
		public void MPXHJDWQULP(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98DBD60", Offset = "0x98DA760", VA = "0x1898DBD60", Slot = "29")]
		public void MRPTONBLNHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98DB020", Offset = "0x98D9A20", VA = "0x1898DB020", Slot = "30")]
		public void CVQJYWEXCOY(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98DB490", Offset = "0x98D9E90", VA = "0x1898DB490", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98DB360", Offset = "0x98D9D60", VA = "0x1898DB360", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD78E30", Offset = "0xD77830", VA = "0x180D78E30", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98DB210", Offset = "0x98D9C10", VA = "0x1898DB210", Slot = "43")]
		public bool CanConnectTo(int slotIndex, AMFBTRVCLRD otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "44")]
		public void ParentChanged(int slotIndex, AMFBTRVCLRD newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "45")]
		public void ChildAdded(int slotIndex, AMFBTRVCLRD newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "46")]
		public void ChildRemoved(int slotIndex, AMFBTRVCLRD removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "47")]
		public void ConnectionModified(int slotIndex, AMFBTRVCLRD parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98DC1D0", Offset = "0x98DABD0", VA = "0x1898DC1D0", Slot = "48")]
		public void RootChanged(AMFBTRVCLRD previousRootConnectable, AMFBTRVCLRD newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98DC730", Offset = "0x98DB130", VA = "0x1898DC730", Slot = "23")]
		public void YTYMZKSQSRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98DC180", Offset = "0x98DAB80", VA = "0x1898DC180", Slot = "24")]
		public void RLQFHZQVQKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98DC290", Offset = "0x98DAC90", VA = "0x1898DC290")]
		private void TOSPOPUDKRV(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(CMARKEXUVFK), new string[] { })]
	public class UXBXNLLUJBL : CMARKEXUVFK, KZDQEQUQNCZ, PGANNZBSSYB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private YAICDCJTFJO DQLZWBXICZJ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object MEDFZXNRUGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x98E02A0", Offset = "0x98DECA0", VA = "0x1898E02A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98E0330", Offset = "0x98DED30", VA = "0x1898E0330", Slot = "5")]
		private void UBCVDPRMWRT(VBPLBVQDNMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF8A2E0", Offset = "0xF88CE0", VA = "0x180F8A2E0", Slot = "6")]
		private void UYXNLSZGBZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public UXBXNLLUJBL()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(BYHNCOWWIKU), new string[] { "Ignore", "Mock" })]
	public class ZEZXCVJLZWB : BYHNCOWWIKU, PLILCFKSRWT
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool QETWNCSRYPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD> HKJZGTGQFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x98E0AA0", Offset = "0x98DF4A0", VA = "0x1898E0AA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x98E0940", Offset = "0x98DF340", VA = "0x1898E0940", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD> QLUEWNQWZXU
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x98E09F0", Offset = "0x98DF3F0", VA = "0x1898E09F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x98E0B50", Offset = "0x98DF550", VA = "0x1898E0B50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD, AMFBTRVCLRD> OWVDXOWEJFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x98E07E0", Offset = "0x98DF1E0", VA = "0x1898E07E0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x98E0890", Offset = "0x98DF290", VA = "0x1898E0890", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "26")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "12")]
		public void Initialize(GameObject gameObject, NSZOVVNPIJR configData, RWZZUAKIDOQ rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "14")]
		public void WSFSWRIEDET(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "15")]
		public void QNRHIMHGGAQ(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "16")]
		public void VYQYATCDLVN(AMFBTRVCLRD a, HashSet<AMFBTRVCLRD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "17")]
		public void FQGPVTEZGIP(AMFBTRVCLRD a, AMFBTRVCLRD b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "18")]
		public void ZWDFORZDSEJ(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "19")]
		public void AHATMLBGFTD(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "20")]
		public ConnectableGraphData WITHAKROGEE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "21")]
		public ConnectableGraphData WEABRPHIXSI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "22")]
		public bool DAZVTTVWQRQ(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "23")]
		public void HRPPHYETQDH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "24")]
		public void GEZDJQGMVKB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "25")]
		public void GNVHGTCNLIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ZEZXCVJLZWB()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AMFBTRVCLRD : WCDYBXKQGKY, IEquatable<AMFBTRVCLRD>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface WCDYBXKQGKY
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		AMFBTRVCLRD ParentConnectable
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
		bool CanConnectTo(int slotIndex, AMFBTRVCLRD otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, AMFBTRVCLRD newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, AMFBTRVCLRD newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, AMFBTRVCLRD removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, AMFBTRVCLRD parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(AMFBTRVCLRD previousRootConnectable, AMFBTRVCLRD newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BYHNCOWWIKU : PLILCFKSRWT
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool QETWNCSRYPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<AMFBTRVCLRD, AMFBTRVCLRD> HKJZGTGQFNC;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<AMFBTRVCLRD, AMFBTRVCLRD> QLUEWNQWZXU;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<AMFBTRVCLRD, AMFBTRVCLRD, AMFBTRVCLRD> OWVDXOWEJFQ;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, NSZOVVNPIJR configData, RWZZUAKIDOQ rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WSFSWRIEDET(AMFBTRVCLRD a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void QNRHIMHGGAQ(AMFBTRVCLRD a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void VYQYATCDLVN(AMFBTRVCLRD a, HashSet<AMFBTRVCLRD> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void FQGPVTEZGIP(AMFBTRVCLRD a, AMFBTRVCLRD b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZWDFORZDSEJ(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void AHATMLBGFTD(AMFBTRVCLRD a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData WITHAKROGEE(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData WEABRPHIXSI(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool DAZVTTVWQRQ(OFXQUQYPCHS a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void HRPPHYETQDH(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void GEZDJQGMVKB(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void GNVHGTCNLIO(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ZMYNXIZYVSI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AMFBTRVCLRD MGNWNHBEQTE(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AMFBTRVCLRD FWAAQXHQQLH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MBMFQFVUJIR(AMFBTRVCLRD a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool OZCDIPPVPWP();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YBFHCQQPYZK(AMFBTRVCLRD a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface CUEYMGZMWEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KKEKQWARIXR(JXOUTCQTCDN a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WNTEGODZUIK(JXOUTCQTCDN a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string DRWUHAXDNOZ(JXOUTCQTCDN a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid NQXQCWRJQLW(JXOUTCQTCDN a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int WXTMFIKEAMR(JXOUTCQTCDN a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZINRZBYTMXC(JXOUTCQTCDN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(AMFBTRVCLRD childConnectable, int childConnectableSlot, AMFBTRVCLRD parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(AMFBTRVCLRD previousRootConnectable, AMFBTRVCLRD newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JXOUTCQTCDN : AMFBTRVCLRD, WCDYBXKQGKY, IEquatable<AMFBTRVCLRD>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface WWBUOLOKJMR : WCDYBXKQGKY
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		AMFBTRVCLRD NTLSLIVWAPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<AMFBTRVCLRD> WLVXWKYYQDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 JCOMCCGNQXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion OIKPFTNIGFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool QSCNVGFGAPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool LBZNBWIDOMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler ORMPAASXSQC;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler YRBXCNVXMOM;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler WFFTGWLPWED;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler JKYIBEOBTDI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MKLPGREUVAY();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void LAIGKNPAYFP();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YTYMZKSQSRE();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void RLQFHZQVQKR();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void LJTDVGWKNFC(int a, AMFBTRVCLRD b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void HMOWVOFOGJW();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void WFLJWSKDNLU(int a, AMFBTRVCLRD b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void YJCQJBHOJOM(AMFBTRVCLRD a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void MRPTONBLNHZ();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void CVQJYWEXCOY(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void MPXHJDWQULP(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GDEEYQAJWUN
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 WUVWWTGSVHW
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
	public interface NSZOVVNPIJR
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool QSFXZTEXMKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		YHZQTPYWSYA IEGIQTAZOVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, NSZOVVNPIJR
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
		public bool QSFXZTEXMKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public YHZQTPYWSYA IEGIQTAZOVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x98CCAA0", Offset = "0x98CB4A0", VA = "0x1898CCAA0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x98CCB60", Offset = "0x98CB560", VA = "0x1898CCB60")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AMFBTRVCLRD connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x98CD020", Offset = "0x98CBA20", VA = "0x1898CD020")]
		public ConnectableLink(AMFBTRVCLRD connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x98CD110", Offset = "0x98CBB10", VA = "0x1898CD110")]
		public ConnectableLink(AMFBTRVCLRD connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x98CD080", Offset = "0x98CBA80", VA = "0x1898CD080")]
		public ConnectableLink(AMFBTRVCLRD connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x98CCBB0", Offset = "0x98CB5B0", VA = "0x1898CCBB0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x98CCC60", Offset = "0x98CB660", VA = "0x1898CCC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : SKOXTSSUFGY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform AAKCKIFEUAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private YHZQTPYWSYA ZCHJFSJYBLW;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x91F7680", Offset = "0x91F6080", VA = "0x1891F7680", Slot = "4")]
		public void Initialize(Transform transform, YHZQTPYWSYA linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x98CE440", Offset = "0x98CCE40", VA = "0x1898CE440", Slot = "5")]
		public YHZQTPYWSYA LEGAGFFNVSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x98CE3D0", Offset = "0x98CCDD0", VA = "0x1898CE3D0", Slot = "6")]
		public void KSMULIKPBAQ(YHZQTPYWSYA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, WYLKVTLSAAI
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CRLCKBCPMKT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AMFBTRVCLRD NEFHQBODPJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AMFBTRVCLRD VQFFXXHRPHA;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CRLCKBCPMKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x98CC470", Offset = "0x98CAE70", VA = "0x1898CC470")]
			internal bool JVOBFZSQWRO(PLNDZMCXVJR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly DDYCMPKMEZG RUASICTXSSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private SVPKBCIYLUT EQLLFTEROXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IZFOVLIIAIB YHQBDCXFMQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool DGGBCBUQOMN;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log IHMUQIDVWPB;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public PLNDZMCXVJR DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x98D0740", Offset = "0x98CF140", VA = "0x1898D0740")]
		public bool KBSXYBOPBCB([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x98CF310", Offset = "0x98CDD10", VA = "0x1898CF310")]
		private bool BTIKMQTDPGI([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x98D20E0", Offset = "0x98D0AE0", VA = "0x1898D20E0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x98D0460", Offset = "0x98CEE60", VA = "0x1898D0460", Slot = "5")]
		public void Initialize(BYHNCOWWIKU manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x98CEF00", Offset = "0x98CD900", VA = "0x1898CEF00", Slot = "17")]
		public void ASJZEZHBPPS(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x98D0260", Offset = "0x98CEC60", VA = "0x1898D0260", Slot = "12")]
		public void GOGVLFHIWLJ(Func<AMFBTRVCLRD, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x98D0130", Offset = "0x98CEB30", VA = "0x1898D0130")]
		private void GOGVLFHIWLJ(DDYCMPKMEZG a, Func<AMFBTRVCLRD, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x98D1650", Offset = "0x98D0050", VA = "0x1898D1650", Slot = "11")]
		public void QPOMNUATJLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x98D1970", Offset = "0x98D0370", VA = "0x1898D1970", Slot = "8")]
		public bool UYUKPPTUIWQ(AMFBTRVCLRD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98D0F40", Offset = "0x98CF940", VA = "0x1898D0F40")]
		private bool PXQHPGDYRFP(AMFBTRVCLRD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98D18C0", Offset = "0x98D02C0", VA = "0x1898D18C0")]
		private static bool UUBWKXQIGPN(AMFBTRVCLRD a, DDYCMPKMEZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98CEF30", Offset = "0x98CD930", VA = "0x1898CEF30")]
		private void ATIWDZQVMIP(Transform a, DDYCMPKMEZG b, DDYCMPKMEZG[] c, AMFBTRVCLRD d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98CF8D0", Offset = "0x98CE2D0", VA = "0x1898CF8D0")]
		private ConnectableLink CUQZTGLGHFM(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98D0D80", Offset = "0x98CF780", VA = "0x1898D0D80")]
		private static bool PFJNQZKHPUB(DDYCMPKMEZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x98D0750", Offset = "0x98CF150", VA = "0x1898D0750", Slot = "9")]
		public bool KNLXFRTEWYY(AMFBTRVCLRD a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x98D1670", Offset = "0x98D0070", VA = "0x1898D1670")]
		private bool RDBFIOOWXQZ(AMFBTRVCLRD a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x98CED80", Offset = "0x98CD780", VA = "0x1898CED80")]
		private static void ALAIICICLKY(AMFBTRVCLRD a, int b, int c, Vector3 d, Quaternion e, DDYCMPKMEZG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x98D0B00", Offset = "0x98CF500", VA = "0x1898D0B00")]
		private void NNKRUWIBHXP(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x98D0270", Offset = "0x98CEC70", VA = "0x1898D0270")]
		private void HFVBOASIXRD(DDYCMPKMEZG a, AMFBTRVCLRD b, AMFBTRVCLRD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x98D02E0", Offset = "0x98CECE0", VA = "0x1898D02E0")]
		private void HFVBOASIXRD(AMFBTRVCLRD a, AMFBTRVCLRD b, AMFBTRVCLRD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x98CFB20", Offset = "0x98CE520", VA = "0x1898CFB20")]
		private void CYADXUQAEDU(AMFBTRVCLRD a, AMFBTRVCLRD b, AMFBTRVCLRD c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98CFA20", Offset = "0x98CE420", VA = "0x1898CFA20")]
		private void CYADXUQAEDU(DDYCMPKMEZG a, AMFBTRVCLRD b, AMFBTRVCLRD c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x98D1EF0", Offset = "0x98D08F0", VA = "0x1898D1EF0")]
		private void ZSTPAXICWOD(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98D0C20", Offset = "0x98CF620", VA = "0x1898D0C20")]
		private void OKGKXUYOKSV(PLNDZMCXVJR a, PLNDZMCXVJR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x98D05E0", Offset = "0x98CEFE0", VA = "0x1898D05E0", Slot = "18")]
		public AMFBTRVCLRD JTECATZOJUY(AMFBTRVCLRD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x98D1980", Offset = "0x98D0380", VA = "0x1898D1980", Slot = "13")]
		public void VYQYATCDLVN(AMFBTRVCLRD a, HashSet<AMFBTRVCLRD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x98D08C0", Offset = "0x98CF2C0", VA = "0x1898D08C0", Slot = "14")]
		public List<AMFBTRVCLRD> MWNPGFTAWPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x98D0510", Offset = "0x98CEF10", VA = "0x1898D0510")]
		protected PLNDZMCXVJR JIWNOVXHLPG(PLNDZMCXVJR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x98D1D20", Offset = "0x98D0720", VA = "0x1898D1D20")]
		protected DDYCMPKMEZG[] XCVAYXNMIMF(DDYCMPKMEZG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x98D0350", Offset = "0x98CED50", VA = "0x1898D0350")]
		protected bool IHQXGDHJANO(AMFBTRVCLRD a, [Out] DDYCMPKMEZG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x98D1DC0", Offset = "0x98D07C0", VA = "0x1898D1DC0", Slot = "15")]
		public bool YPAJJQNATVO(AMFBTRVCLRD a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x98D07B0", Offset = "0x98CF1B0", VA = "0x1898D07B0")]
		protected DDYCMPKMEZG KPNWUENXRFD(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x98CED20", Offset = "0x98CD720", VA = "0x1898CED20", Slot = "10")]
		public bool AHORAPZKMVG(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x98CFB90", Offset = "0x98CE590", VA = "0x1898CFB90")]
		private bool DCGOQMTRPKD(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x98D07F0", Offset = "0x98CF1F0", VA = "0x1898D07F0")]
		private static bool LVNVYTGGUCB(DDYCMPKMEZG a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x98D0740", Offset = "0x98CF140", VA = "0x1898D0740", Slot = "7")]
		private bool OZCFNDFCKTK([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : BYHNCOWWIKU, PLILCFKSRWT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly ZUKUOYIIEVW container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly IZFOVLIIAIB YHQBDCXFMQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly YZNLFVSIKWG VOBDHYWISIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly UIOXPZYWRPC XMKHXCAXMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly WYLKVTLSAAI TJRTDRAUBFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal UNQMOWOVCGZ XYPHPWBDKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal YEXNNZEVJXU OGUPRCWALTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal SVPKBCIYLUT RKPASLLDHYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool DGGBCBUQOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool FTEALXNHRKO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FTNTCBCBYRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xD5E450", Offset = "0xD5CE50", VA = "0x180D5E450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD5E0E0", Offset = "0xD5CAE0", VA = "0x180D5E0E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x137E420", Offset = "0x137CE20", VA = "0x18137E420", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x28951F0", Offset = "0x2893BF0", VA = "0x1828951F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool QETWNCSRYPH
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD> HKJZGTGQFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x98D3690", Offset = "0x98D2090", VA = "0x1898D3690", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x98D2770", Offset = "0x98D1170", VA = "0x1898D2770", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD> QLUEWNQWZXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x98D3560", Offset = "0x98D1F60", VA = "0x1898D3560", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x98D3D90", Offset = "0x98D2790", VA = "0x1898D3D90", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<AMFBTRVCLRD, AMFBTRVCLRD, AMFBTRVCLRD> OWVDXOWEJFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x98D26B0", Offset = "0x98D10B0", VA = "0x1898D26B0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x98D2710", Offset = "0x98D1110", VA = "0x1898D2710", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x98D3F30", Offset = "0x98D2930", VA = "0x1898D3F30")]
		public LegacyConnectableManager(ZUKUOYIIEVW container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x98D2E10", Offset = "0x98D1810", VA = "0x1898D2E10", Slot = "12")]
		public void Initialize(GameObject gameObject, NSZOVVNPIJR configData, RWZZUAKIDOQ rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x98D35C0", Offset = "0x98D1FC0", VA = "0x1898D35C0", Slot = "26")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98D36F0", Offset = "0x98D20F0", VA = "0x1898D36F0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x98D3B90", Offset = "0x98D2590", VA = "0x1898D3B90", Slot = "14")]
		public void WSFSWRIEDET(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x98D3500", Offset = "0x98D1F00", VA = "0x1898D3500", Slot = "15")]
		public void QNRHIMHGGAQ(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x98D27D0", Offset = "0x98D11D0", VA = "0x1898D27D0", Slot = "22")]
		public bool DAZVTTVWQRQ(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x98D2970", Offset = "0x98D1370", VA = "0x1898D2970")]
		internal bool DCGOQMTRPKD([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x98D2820", Offset = "0x98D1220", VA = "0x1898D2820")]
		internal bool DCEQAYQROEF([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x98D3BB0", Offset = "0x98D25B0", VA = "0x1898D3BB0")]
		internal void XLTSMGASKER(AMFBTRVCLRD a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x98D3500", Offset = "0x98D1F00", VA = "0x1898D3500")]
		internal bool LJEICIQSSMF(AMFBTRVCLRD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x98D33D0", Offset = "0x98D1DD0", VA = "0x1898D33D0")]
		internal bool KWVKHOSJGIT(AMFBTRVCLRD a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x98D3770", Offset = "0x98D2170", VA = "0x1898D3770", Slot = "16")]
		public void VYQYATCDLVN(AMFBTRVCLRD a, HashSet<AMFBTRVCLRD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x98D2A80", Offset = "0x98D1480", VA = "0x1898D2A80", Slot = "17")]
		public void FQGPVTEZGIP(AMFBTRVCLRD a, AMFBTRVCLRD b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x98D3DF0", Offset = "0x98D27F0", VA = "0x1898D3DF0", Slot = "18")]
		public void ZWDFORZDSEJ(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x98D2290", Offset = "0x98D0C90", VA = "0x1898D2290", Slot = "19")]
		public void AHATMLBGFTD(AMFBTRVCLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x98D2460", Offset = "0x98D0E60", VA = "0x1898D2460")]
		public void BOJMPAWPOOA([Optional] KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x98D2D80", Offset = "0x98D1780", VA = "0x1898D2D80", Slot = "23")]
		public void HRPPHYETQDH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x98D3A10", Offset = "0x98D2410", VA = "0x1898D3A10", Slot = "20")]
		public ConnectableGraphData WITHAKROGEE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x98D3870", Offset = "0x98D2270", VA = "0x1898D3870", Slot = "21")]
		public ConnectableGraphData WEABRPHIXSI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x98D2D40", Offset = "0x98D1740", VA = "0x1898D2D40", Slot = "25")]
		public void GNVHGTCNLIO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x98D2C90", Offset = "0x98D1690", VA = "0x1898D2C90", Slot = "24")]
		public void GEZDJQGMVKB(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class IZFOVLIIAIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly VEKYMVMWWRQ<AMFBTRVCLRD, AMFBTRVCLRD> HKJZGTGQFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly VEKYMVMWWRQ<AMFBTRVCLRD, AMFBTRVCLRD> QLUEWNQWZXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly VEQFKCGUGCZ<AMFBTRVCLRD, AMFBTRVCLRD, AMFBTRVCLRD> OWVDXOWEJFQ;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x98CE2D0", Offset = "0x98CCCD0", VA = "0x1898CE2D0")]
		public IZFOVLIIAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x98CE270", Offset = "0x98CCC70", VA = "0x1898CE270")]
		public void DFABEREJLPK(AMFBTRVCLRD a, AMFBTRVCLRD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x98CE190", Offset = "0x98CCB90", VA = "0x1898CE190")]
		public void AXMAAKWQADM(AMFBTRVCLRD a, AMFBTRVCLRD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x98CE1F0", Offset = "0x98CCBF0", VA = "0x1898CE1F0")]
		public void BPFFNGSWPHY(AMFBTRVCLRD a, AMFBTRVCLRD b, AMFBTRVCLRD c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class YZNLFVSIKWG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager VDDMESGPCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YEXNNZEVJXU OGUPRCWALTS;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public YZNLFVSIKWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x98E0500", Offset = "0x98DEF00", VA = "0x1898E0500")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98E03F0", Offset = "0x98DEDF0", VA = "0x1898E03F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98E06A0", Offset = "0x98DF0A0", VA = "0x1898E06A0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98E0630", Offset = "0x98DF030", VA = "0x1898E0630")]
		private void OnMasterClientSwitched(KDSOOWCXYNX newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x98E06E0", Offset = "0x98DF0E0", VA = "0x1898E06E0")]
		public void ZDOAMEJZEUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98E0400", Offset = "0x98DEE00", VA = "0x1898E0400")]
		public void GGASIGYISLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class OQHYJEGATTW
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ZUKUOYIIEVW container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x98CDF10", Offset = "0x98CC910", VA = "0x1898CDF10")]
			internal LegacyConnectableManager GINIITLJCYV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98DCCE0", Offset = "0x98DB6E0", VA = "0x1898DCCE0")]
		public static void UUWEQCKEXAR(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x98DCC60", Offset = "0x98DB660", VA = "0x1898DCC60")]
		public static void MIAVWPVSRMO(ZUKUOYIIEVW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, SVPKBCIYLUT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, YHZQTPYWSYA> SLMCICDPYLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation RJQXWNEGSEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SKOXTSSUFGY KEVGRCALCZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private WYLKVTLSAAI TJRTDRAUBFQ;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker JPKLITHAPYU;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x98D4F80", Offset = "0x98D3980", VA = "0x1898D4F80")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x98D45C0", Offset = "0x98D2FC0", VA = "0x1898D45C0", Slot = "7")]
		public void Initialize(WYLKVTLSAAI graph, SKOXTSSUFGY creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x98D4950", Offset = "0x98D3350", VA = "0x1898D4950", Slot = "5")]
		public void XIJFOHJHSMB(PLNDZMCXVJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98D4BF0", Offset = "0x98D35F0", VA = "0x1898D4BF0", Slot = "9")]
		public void XSGBMBKXCRS(PLNDZMCXVJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x98D4D60", Offset = "0x98D3760", VA = "0x1898D4D60", Slot = "8")]
		public void YUCTJDFTBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x98D4600", Offset = "0x98D3000", VA = "0x1898D4600", Slot = "10")]
		public void PIPHACXZNKH(PLNDZMCXVJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x98D4470", Offset = "0x98D2E70", VA = "0x1898D4470", Slot = "11")]
		public void BBTWUGCMTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98D42C0", Offset = "0x98D2CC0", VA = "0x1898D42C0")]
		private bool ASNNNXIRRCS(PLNDZMCXVJR a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class UIOXPZYWRPC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly DDYCMPKMEZG currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly OFXQUQYPCHS parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly OFXQUQYPCHS rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool BUZIDHREPNV
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x98DD160", Offset = "0x98DBB60", VA = "0x1898DD160")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x98DD790", Offset = "0x98DC190", VA = "0x1898DD790")]
			public SerializeNodeInSubgraph(DDYCMPKMEZG currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] OFXQUQYPCHS parentNodeData, [Optional] OFXQUQYPCHS rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x98DD3F0", Offset = "0x98DBDF0", VA = "0x1898DD3F0")]
			public OFXQUQYPCHS NZJDRENIZKU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x98DD0A0", Offset = "0x98DBAA0", VA = "0x1898DD0A0")]
			private OFXQUQYPCHS LGFNNUUSXOQ([Out] OFXQUQYPCHS a, [Out] OFXQUQYPCHS b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x98DD590", Offset = "0x98DBF90", VA = "0x1898DD590")]
			private OFXQUQYPCHS TIPVJKPNPCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x98DD280", Offset = "0x98DBC80", VA = "0x1898DD280")]
			private void NACDCIRRMXM(OFXQUQYPCHS a, OFXQUQYPCHS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x98DCEE0", Offset = "0x98DB8E0", VA = "0x1898DCEE0")]
			private void AQGDFXFEZZN(OFXQUQYPCHS a, OFXQUQYPCHS b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager VDDMESGPCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private WYLKVTLSAAI TJRTDRAUBFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private SVPKBCIYLUT EQLLFTEROXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private YEXNNZEVJXU OGUPRCWALTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool ORIZBXOITHI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool JNWPMXDZHYX
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x98DF470", Offset = "0x98DDE70", VA = "0x1898DF470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool FTNTCBCBYRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x98DEBA0", Offset = "0x98DD5A0", VA = "0x1898DEBA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x98DFB30", Offset = "0x98DE530", VA = "0x1898DFB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98DE1F0", Offset = "0x98DCBF0", VA = "0x1898DE1F0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x98DFE10", Offset = "0x98DE810", VA = "0x1898DFE10")]
		public ConnectableGraphData WITHAKROGEE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x98DFB50", Offset = "0x98DE550", VA = "0x1898DFB50")]
		public ConnectableGraphData WEABRPHIXSI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x98DE160", Offset = "0x98DCB60", VA = "0x1898DE160")]
		public void HRPPHYETQDH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x98DDEE0", Offset = "0x98DC8E0", VA = "0x1898DDEE0")]
		public void GEZDJQGMVKB(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x98DDEB0", Offset = "0x98DC8B0", VA = "0x1898DDEB0")]
		public void GCMOIWHGZRV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x98DDF80", Offset = "0x98DC980", VA = "0x1898DDF80")]
		private void GZEEVDQUKRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98DEBE0", Offset = "0x98DD5E0", VA = "0x1898DEBE0")]
		private OFXQUQYPCHS PAOQUBBASFI(DDYCMPKMEZG a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x98DEE00", Offset = "0x98DD800", VA = "0x1898DEE00")]
		private static void PAUWQGNNZPO(DDYCMPKMEZG a, bool b, OFXQUQYPCHS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x98DE260", Offset = "0x98DCC60", VA = "0x1898DE260")]
		private void JDZHSPUHTRB(DDYCMPKMEZG a, bool b, OFXQUQYPCHS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x98DDE20", Offset = "0x98DC820", VA = "0x1898DDE20")]
		private OFXQUQYPCHS DOYMDQPETBU(DDYCMPKMEZG a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x98DF1E0", Offset = "0x98DDBE0", VA = "0x1898DF1E0")]
		private bool QADJZBELNCE(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x98DF4C0", Offset = "0x98DDEC0", VA = "0x1898DF4C0")]
		private bool RGSYRVYONAV(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x98DEBC0", Offset = "0x98DD5C0", VA = "0x1898DEBC0")]
		private bool ORVQCVEBVFV(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x98DFCF0", Offset = "0x98DE6F0", VA = "0x1898DFCF0")]
		private static bool WIBYDOHDBXQ(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x98DDB90", Offset = "0x98DC590", VA = "0x1898DDB90")]
		public static bool DAZVTTVWQRQ(OFXQUQYPCHS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x98DE480", Offset = "0x98DCE80", VA = "0x1898DE480")]
		private AMFBTRVCLRD KHNELERIYNO(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x98DE7C0", Offset = "0x98DD1C0", VA = "0x1898DE7C0")]
		private AMFBTRVCLRD MGNWNHBEQTE(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x98DDA00", Offset = "0x98DC400", VA = "0x1898DDA00")]
		private AMFBTRVCLRD CAWIYRUDCTX(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x98DA780", Offset = "0x98D9180", VA = "0x1898DA780")]
		private static Guid YTQAYFZVJBZ(OFXQUQYPCHS a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x98DFF80", Offset = "0x98DE980", VA = "0x1898DFF80")]
		private string XCWBKNDFRJI(OFXQUQYPCHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x98DF050", Offset = "0x98DDA50", VA = "0x1898DF050")]
		private bool PGBNGFDINIR(DDYCMPKMEZG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x98DE940", Offset = "0x98DD340", VA = "0x1898DE940")]
		private static void MGRLOMQLJTX(DDYCMPKMEZG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public UIOXPZYWRPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AMFBTRVCLRD child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AMFBTRVCLRD parent;

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
		public ConnectableLink MJIVVSCSGTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x98CD1B0", Offset = "0x98CBBB0", VA = "0x1898CD1B0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink IUEYWDOXZIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x98CD250", Offset = "0x98CBC50", VA = "0x1898CD250")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x98CD280", Offset = "0x98CBC80", VA = "0x1898CD280")]
		public ConnectionOperationData(AMFBTRVCLRD child, AMFBTRVCLRD parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface WYLKVTLSAAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		PLNDZMCXVJR DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(BYHNCOWWIKU manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KBSXYBOPBCB([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UYUKPPTUIWQ(AMFBTRVCLRD a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KNLXFRTEWYY(AMFBTRVCLRD a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AHORAPZKMVG(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QPOMNUATJLV();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GOGVLFHIWLJ(Func<AMFBTRVCLRD, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VYQYATCDLVN(AMFBTRVCLRD a, HashSet<AMFBTRVCLRD> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<AMFBTRVCLRD> MWNPGFTAWPB();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool YPAJJQNATVO(AMFBTRVCLRD a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ASJZEZHBPPS(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(PLNDZMCXVJR node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface PLNDZMCXVJR
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		AMFBTRVCLRD VXOAAGVAKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		PLNDZMCXVJR ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink YHLQZEWCAHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool KBJHDYZOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface YHZQTPYWSYA : TWJIFHOKQZG.YJQYINYCJQO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SRPDLCJVRSE(AMFBTRVCLRD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QGKSLPKQFGE(AMFBTRVCLRD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OLDVKHTFRKV(AMFBTRVCLRD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GCJKAWKPNSP(AMFBTRVCLRD a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YHZQTPYWSYA OWSMHRQRHAC(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface SKOXTSSUFGY
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, YHZQTPYWSYA linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YHZQTPYWSYA LEGAGFFNVSW();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KSMULIKPBAQ(YHZQTPYWSYA a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface UNQMOWOVCGZ : ZMYNXIZYVSI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PUENDKVROXZ();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XZZAMTJDGXM(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface SVPKBCIYLUT
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XIJFOHJHSMB(PLNDZMCXVJR a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(WYLKVTLSAAI graph, SKOXTSSUFGY linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YUCTJDFTBFE();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XSGBMBKXCRS(PLNDZMCXVJR a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PIPHACXZNKH(PLNDZMCXVJR a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BBTWUGCMTWL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class DDYCMPKMEZG : PLNDZMCXVJR
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class BTYIIVPTFJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink XFKCYFPJYUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public DDYCMPKMEZG EQHXYJKFSOK;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BTYIIVPTFJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x98CC330", Offset = "0x98CAD30", VA = "0x1898CC330")]
			internal bool ZTYKCMAHZXX(PLNDZMCXVJR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink MPFHEPPVTOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<DDYCMPKMEZG> IXEJHKRESMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DDYCMPKMEZG CGAJDEXIPLB;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink YHLQZEWCAHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x517FC10", Offset = "0x517E610", VA = "0x18517FC10", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x98CDCF0", Offset = "0x98CC6F0", VA = "0x1898CDCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DDYCMPKMEZG CVRJANTESXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x98CD840", Offset = "0x98CC240", VA = "0x1898CD840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public PLNDZMCXVJR ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AMFBTRVCLRD VXOAAGVAKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool KBJHDYZOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x98CDD70", Offset = "0x98CC770", VA = "0x1898CDD70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NIWLBRWQKXY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x98CDD20", Offset = "0x98CC720", VA = "0x1898CDD20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected DDYCMPKMEZG VQTHZPRYINY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x98CD730", Offset = "0x98CC130", VA = "0x1898CD730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x98CDD80", Offset = "0x98CC780", VA = "0x1898CDD80")]
		public DDYCMPKMEZG(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x98CD920", Offset = "0x98CC320", VA = "0x1898CD920")]
		public DDYCMPKMEZG NGOTFISRHYR(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x98CD5B0", Offset = "0x98CBFB0", VA = "0x1898CD5B0")]
		public DDYCMPKMEZG JAZNVWFZFOJ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x98CDA60", Offset = "0x98CC460", VA = "0x1898CDA60")]
		public DDYCMPKMEZG Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x98CD460", Offset = "0x98CBE60", VA = "0x1898CD460")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x98CDC40", Offset = "0x98CC640", VA = "0x1898CDC40")]
		public DDYCMPKMEZG Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x98CD2F0", Offset = "0x98CBCF0", VA = "0x1898CD2F0")]
		private static void ASJZEZHBPPS(DDYCMPKMEZG a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x98CD450", Offset = "0x98CBE50", VA = "0x1898CD450", Slot = "9")]
		public void ASJZEZHBPPS(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x98CD750", Offset = "0x98CC150", VA = "0x1898CD750")]
		public static DDYCMPKMEZG KPNWUENXRFD(DDYCMPKMEZG a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface YEXNNZEVJXU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool JNWPMXDZHYX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> ZGPVAKWZUXR;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<KDSOOWCXYNX> NGUPMDHOFVZ;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SRPDLCJVRSE(LegacyConnectableManager a, RWZZUAKIDOQ b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FQGPVTEZGIP(AMFBTRVCLRD a, AMFBTRVCLRD b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ZWDFORZDSEJ(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void QKLGWFJJJBK(ConnectableGraphData a, [Optional] KDSOOWCXYNX b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class ESMAHKFCWBS
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x98CDE80", Offset = "0x98CC880", VA = "0x1898CDE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x98CDED0", Offset = "0x98CC8D0", VA = "0x1898CDED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x98CDE20", Offset = "0x98CC820", VA = "0x1898CDE20")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class NFNSVVHNSXJ : YEXNNZEVJXU, IDisposable, YBXVDYAYISE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager VDDMESGPCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private RWZZUAKIDOQ WIAKWAFUCSQ;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JNWPMXDZHYX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x98D5950", Offset = "0x98D4350", VA = "0x1898D5950", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x98D5610", Offset = "0x98D4010", VA = "0x1898D5610", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView AGRBJTIBKUI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x98D6190", Offset = "0x98D4B90", VA = "0x1898D6190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> ZGPVAKWZUXR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x98D5790", Offset = "0x98D4190", VA = "0x1898D5790", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x98D56F0", Offset = "0x98D40F0", VA = "0x1898D56F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<KDSOOWCXYNX> NGUPMDHOFVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x98D5650", Offset = "0x98D4050", VA = "0x1898D5650", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x98D6220", Offset = "0x98D4C20", VA = "0x1898D6220", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x98D6100", Offset = "0x98D4B00", VA = "0x1898D6100", Slot = "10")]
		public void SRPDLCJVRSE(LegacyConnectableManager a, RWZZUAKIDOQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x98D54A0", Offset = "0x98D3EA0", VA = "0x1898D54A0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x98D54F0", Offset = "0x98D3EF0", VA = "0x1898D54F0", Slot = "11")]
		public void FQGPVTEZGIP(AMFBTRVCLRD a, AMFBTRVCLRD b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x98D62C0", Offset = "0x98D4CC0", VA = "0x1898D62C0", Slot = "12")]
		public void ZWDFORZDSEJ(AMFBTRVCLRD a, int b, AMFBTRVCLRD c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x98D5830", Offset = "0x98D4230", VA = "0x1898D5830", Slot = "13")]
		public void QKLGWFJJJBK(ConnectableGraphData a, [Optional] KDSOOWCXYNX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x98D5BE0", Offset = "0x98D45E0", VA = "0x1898D5BE0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(AMFBTRVCLRD objectToReparent, int objectToReparentSlotIndex, AMFBTRVCLRD newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x98D59F0", Offset = "0x98D43F0", VA = "0x1898D59F0")]
		[RPCMethod]
		private void RpcMasterModifyNode(AMFBTRVCLRD connectableToModify, AMFBTRVCLRD expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x98D5FD0", Offset = "0x98D49D0", VA = "0x1898D5FD0")]
		[RPCMethod]
		private void RpcReparentNodes(AMFBTRVCLRD objectToReparent, int objectToReparentSlotIndex, AMFBTRVCLRD newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x98D5EE0", Offset = "0x98D48E0", VA = "0x1898D5EE0")]
		[RPCMethod]
		private void RpcModifyNode(AMFBTRVCLRD connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x98D59B0", Offset = "0x98D43B0", VA = "0x1898D59B0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public NFNSVVHNSXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, YHZQTPYWSYA, TWJIFHOKQZG.YJQYINYCJQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x98CE670", Offset = "0x98CD070", VA = "0x1898CE670", Slot = "4")]
		private void FYPMBGZJJRV(AMFBTRVCLRD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x98CEAB0", Offset = "0x98CD4B0", VA = "0x1898CEAB0", Slot = "5")]
		private void RLMLSFBCMAH(AMFBTRVCLRD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x98CE510", Offset = "0x98CCF10", VA = "0x1898CE510", Slot = "6")]
		private void BZVGQASPRFG(AMFBTRVCLRD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x98CE8C0", Offset = "0x98CD2C0", VA = "0x1898CE8C0", Slot = "7")]
		private void NSSSLDWAAJG(AMFBTRVCLRD a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x98CE850", Offset = "0x98CD250", VA = "0x1898CE850", Slot = "8")]
		private YHZQTPYWSYA NNKGFBGCJNN(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x98CE7F0", Offset = "0x98CD1F0", VA = "0x1898CE7F0", Slot = "9")]
		private void JOCPNPJVSMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class SQTMBHJLSZY
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C730", Offset = "0x3F1B130", VA = "0x183F1C730")]
		public static GZMMKLOJPFL<a> DHTZVPSNGHW<a>(this ZUKUOYIIEVW a)
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
