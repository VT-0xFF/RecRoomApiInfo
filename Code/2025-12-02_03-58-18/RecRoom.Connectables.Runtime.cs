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
		[Cpp2IlInjected.Address(RVA = "0x80E5C80", Offset = "0x80E4880", VA = "0x1880E5C80", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		private int[] RXQWJMLBFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] RXLPMFRDWGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset DXAPYCEYZZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset DXFWVIYWJLH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1EE26B0", Offset = "0x1EE12B0", VA = "0x181EE26B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80F13A0", Offset = "0x80EFFA0", VA = "0x1880F13A0")]
		private void JGBTHBSKOEG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80F14F0", Offset = "0x80F00F0", VA = "0x1880F14F0")]
		private void JGHAEIMHXPP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80F1640", Offset = "0x80F0240", VA = "0x1880F1640", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80F1950", Offset = "0x80F0550", VA = "0x1880F1950")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : YFCKQXWLECD, HJESUUHTFVQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class YHWCXQJSDPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public SQYEMCNRKEX WFBRIILUROP;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public YHWCXQJSDPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x80F11E0", Offset = "0x80EFDE0", VA = "0x1880F11E0")]
			internal object ESVBTLELDAE(SQYEMCNRKEX a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class YHQWAJPUUDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public SQYEMCNRKEX WQLDXWCLOBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public YHWCXQJSDPH CFCUCJZVXTS;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public YHQWAJPUUDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x80F0F90", Offset = "0x80EFB90", VA = "0x1880F0F90")]
			internal object ETAIQRYIMLN((SQYEMCNRKEX child, SQYEMCNRKEX nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KRFCDKNQFHQ : IEnumerable<DFHWJYQWSIY>, IEnumerable, IEnumerator<DFHWJYQWSIY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private DFHWJYQWSIY VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId OKACQFVRCRB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId YVNJEEJQITY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private KYJOVNSGQOU VTFRXTZVKPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray MSILEXSYWIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator KYMEODWGYXD;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private DFHWJYQWSIY NMPQBECTTOO
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public KRFCDKNQFHQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x80DEF20", Offset = "0x80DDB20", VA = "0x1880DEF20", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x80DEAD0", Offset = "0x80DD6D0", VA = "0x1880DEAD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x80DEA90", Offset = "0x80DD690", VA = "0x1880DEA90")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x80DEAB0", Offset = "0x80DD6B0", VA = "0x1880DEAB0")]
			private void LTHDVLZCRLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x80DEEE0", Offset = "0x80DDAE0", VA = "0x1880DEEE0", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x80DEE30", Offset = "0x80DDA30", VA = "0x1880DEE30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DFHWJYQWSIY> OSGHVWSIGQF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x80DEE30", Offset = "0x80DDA30", VA = "0x1880DEE30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log HGXXWCDKMWW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log GBTACKSZJQU;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log VGPSGGUSNLW;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log RYNXDKZRPWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ZZAXAEVPTUX UNHBNVEUCTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private RIWGTQDWUCY UYTJFMWOWZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ILLIEDLHHJL ZLGGZBWMNNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PIZMEJFYCYZ TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private YJSMLIHPGEB WXCQCUGRVRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TDDZTPYEXRB LYNOCPNQZSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly ODQHFMMLMHW EXLQJFRUCRJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool TDZVKIVXUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BF0", Offset = "0xA9F7F0", VA = "0x180AA0BF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA0AD0", Offset = "0xA9F6D0", VA = "0x180AA0AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ICHPNQRFEJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY> IKRHSCWEONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x80E7AB0", Offset = "0x80E66B0", VA = "0x1880E7AB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x80E8AB0", Offset = "0x80E76B0", VA = "0x1880E8AB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY> GBREVQGENKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80E9D20", Offset = "0x80E8920", VA = "0x1880E9D20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x80E9E40", Offset = "0x80E8A40", VA = "0x1880E9E40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY, DFHWJYQWSIY> NGVLDMIMFYT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x80E9BE0", Offset = "0x80E87E0", VA = "0x1880E9BE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80E6460", Offset = "0x80E5060", VA = "0x1880E6460", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80EAB70", Offset = "0x80E9770", VA = "0x1880EAB70")]
		public OMConnectableManager(URVRSSRGCJF container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80E75C0", Offset = "0x80E61C0", VA = "0x1880E75C0", Slot = "12")]
		public void Initialize(GameObject gameObject, MXSTWLAKHDU configData, NFABTAFLYGJ sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80E88E0", Offset = "0x80E74E0", VA = "0x1880E88E0", Slot = "26")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80E8170", Offset = "0x80E6D70", VA = "0x1880E8170", Slot = "22")]
		public bool NTPSUVFFPFF(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80E73B0", Offset = "0x80E5FB0", VA = "0x1880E73B0")]
		private void IQSHXHIIHMI(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80E84D0", Offset = "0x80E70D0", VA = "0x1880E84D0")]
		private void OGGUVVHIOUC(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80E6DC0", Offset = "0x80E59C0", VA = "0x1880E6DC0")]
		private void FVBMTSPZJLO(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80E7D60", Offset = "0x80E6960", VA = "0x1880E7D60")]
		private void NOHENVHTHBJ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80E81C0", Offset = "0x80E6DC0", VA = "0x1880E81C0", Slot = "14")]
		public void OGBNJYRINGK(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "15")]
		public void WOWKLYECNPX(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80E6C20", Offset = "0x80E5820", VA = "0x1880E6C20", Slot = "17")]
		public void ETSTOTSNQGM(DFHWJYQWSIY a, DFHWJYQWSIY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80E6AE0", Offset = "0x80E56E0", VA = "0x1880E6AE0")]
		public void ETSTOTSNQGM(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA970", Offset = "0x80E9570", VA = "0x1880EA970")]
		public void YZDKTHLAMRW(DFHWJYQWSIY a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80E7020", Offset = "0x80E5C20", VA = "0x1880E7020", Slot = "18")]
		public void HFIRSBOBTQE(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80EA550", Offset = "0x80E9150", VA = "0x1880EA550")]
		private float YBVBTACRXKQ(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80E7180", Offset = "0x80E5D80", VA = "0x1880E7180")]
		public void HFIRSBOBTQE(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80EA600", Offset = "0x80E9200", VA = "0x1880EA600", Slot = "19")]
		public void YFUSJINKXJM(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x80E9450", Offset = "0x80E8050", VA = "0x1880E9450", Slot = "16")]
		public void TJHPKLXIWQG(DFHWJYQWSIY a, HashSet<DFHWJYQWSIY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "20")]
		public ConnectableGraphData FVMZWXRUVCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "21")]
		public ConnectableGraphData IFLDDBWRYXH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80EA770", Offset = "0x80E9370", VA = "0x1880EA770", Slot = "23")]
		public void YKWCTAIAFFO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80E7CF0", Offset = "0x80E68F0", VA = "0x1880E7CF0", Slot = "24")]
		public void NDEVUCMFSHU(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80EA530", Offset = "0x80E9130", VA = "0x1880EA530", Slot = "25")]
		public void XZEITTFGZDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80E9F50", Offset = "0x80E8B50", VA = "0x1880E9F50")]
		private void XBKDCEUVPGC(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80E8B60", Offset = "0x80E7760", VA = "0x1880E8B60")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80E9DD0", Offset = "0x80E89D0", VA = "0x1880E9DD0")]
		private void WBFKFSISBCR(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80E9C90", Offset = "0x80E8890", VA = "0x1880E9C90")]
		[IteratorStateMachine(typeof(KRFCDKNQFHQ))]
		public IEnumerable<DFHWJYQWSIY> USPWZGURXTQ(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80E6620", Offset = "0x80E5220", VA = "0x1880E6620")]
		internal DFHWJYQWSIY DLOIYNWXVHT(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80E86F0", Offset = "0x80E72F0", VA = "0x1880E86F0")]
		internal ObjectLocalId PBERDALPXMN(DFHWJYQWSIY a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80E9660", Offset = "0x80E8260", VA = "0x1880E9660")]
		private bool TWMEHEZNEJK(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80E9EF0", Offset = "0x80E8AF0", VA = "0x1880E9EF0")]
		private bool WISSVESPRGE(SQYEMCNRKEX a, [Out] DFHWJYQWSIY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80E6750", Offset = "0x80E5350", VA = "0x1880E6750")]
		private DFHWJYQWSIY DLOIYNWXVHT(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80E6140", Offset = "0x80E4D40", VA = "0x1880E6140")]
		private DFHWJYQWSIY AHXHZGBZTLE(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80EA360", Offset = "0x80E8F60", VA = "0x1880EA360")]
		private DFHWJYQWSIY XXIXKCBDJZZ(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80E6D80", Offset = "0x80E5980", VA = "0x1880E6D80")]
		private static Guid FJKDLLFIKDC(SQYEMCNRKEX a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80E72C0", Offset = "0x80E5EC0", VA = "0x1880E72C0")]
		private string HWGLYPLNKWR(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80EA7E0", Offset = "0x80E93E0", VA = "0x1880EA7E0")]
		private void YSLXPCLTZKO(DFHWJYQWSIY a, DFHWJYQWSIY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80E7B60", Offset = "0x80E6760", VA = "0x1880E7B60")]
		private void MSYHLHGKSMK(DFHWJYQWSIY a, DFHWJYQWSIY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80E8880", Offset = "0x80E7480", VA = "0x1880E8880")]
		private void PDRSTUUGQWQ(DFHWJYQWSIY a, DFHWJYQWSIY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80E62D0", Offset = "0x80E4ED0", VA = "0x1880E62D0")]
		private void AVLDKCPUGQF(DFHWJYQWSIY a, DFHWJYQWSIY b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80E6510", Offset = "0x80E5110", VA = "0x1880E6510")]
		private void BVYSIRKLZRW(ObjectLocalId a, DFHWJYQWSIY b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80E7830", Offset = "0x80E6430", VA = "0x1880E7830")]
		private void LULSJALRICT(ObjectLocalId a, DFHWJYQWSIY b, DFHWJYQWSIY c, DFHWJYQWSIY d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HYQHFHVYFMO
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public URVRSSRGCJF container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x80DE640", Offset = "0x80DD240", VA = "0x1880DE640")]
			internal OMConnectableManager JBTXQLUACLG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80DE790", Offset = "0x80DD390", VA = "0x1880DE790")]
		public static void PWYMCPSVMUA(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80DE740", Offset = "0x80DD340", VA = "0x1880DE740")]
		public static void BVYEIGEQWVJ(URVRSSRGCJF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : AKLNJHSNXRK, TKSCPDNTBON
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx SDVVPFMMUVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager BEBOJBOBWHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly AVNGAQRLRFM GNVBOMDRVOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly NOZHPTPGUVY TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HUXBELZHCBW[] YKDMEXTEZKU;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DFHWJYQWSIY ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x80EC790", Offset = "0x80EB390", VA = "0x1880EC790", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DFHWJYQWSIY JTLVMMHKTRF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x80EBCB0", Offset = "0x80EA8B0", VA = "0x1880EBCB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 JXPMQGNLQBT
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80EB1A0", Offset = "0x80E9DA0", VA = "0x1880EB1A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion FGOUDLPGURO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x80EBBB0", Offset = "0x80EA7B0", VA = "0x1880EBBB0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GYLHZJNGZOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x80EBE40", Offset = "0x80EAA40", VA = "0x1880EBE40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<DFHWJYQWSIY> OBMQCWKNLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x80EB400", Offset = "0x80EA000", VA = "0x1880EB400", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool IVDNCCDSNWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB3C4E0", Offset = "0xB3B0E0", VA = "0x180B3C4E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB87E30", Offset = "0xB86A30", VA = "0x180B87E30", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x80EC9A0", Offset = "0x80EB5A0", VA = "0x1880EC9A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x80EC6A0", Offset = "0x80EB2A0", VA = "0x1880EC6A0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x80EC6C0", Offset = "0x80EB2C0", VA = "0x1880EC6C0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x80EC7F0", Offset = "0x80EB3F0", VA = "0x1880EC7F0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x80EC8D0", Offset = "0x80EB4D0", VA = "0x1880EC8D0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool HQIWCPIRRRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x80EB480", Offset = "0x80EA080", VA = "0x1880EB480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler LDTCTSNHCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x80EB0D0", Offset = "0x80E9CD0", VA = "0x1880EB0D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80EAF90", Offset = "0x80E9B90", VA = "0x1880EAF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler ELYTWBYRPOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x80EBB60", Offset = "0x80EA760", VA = "0x1880EBB60", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x80EB4D0", Offset = "0x80EA0D0", VA = "0x1880EB4D0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler PVWUWDIXKFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x80EB430", Offset = "0x80EA030", VA = "0x1880EB430", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x80EC2B0", Offset = "0x80EAEB0", VA = "0x1880EC2B0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler OMCYRZNPIRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x80EAEF0", Offset = "0x80E9AF0", VA = "0x1880EAEF0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x80EC210", Offset = "0x80EAE10", VA = "0x1880EC210", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x80EC5A0", Offset = "0x80EB1A0", VA = "0x1880EC5A0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, AVNGAQRLRFM connectableTool, HUXBELZHCBW[] connectionPoints, NOZHPTPGUVY callbacks, YFCKQXWLECD connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80EAEC0", Offset = "0x80E9AC0", VA = "0x1880EAEC0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "21")]
		public void VGJFGOFKCUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x80EB520", Offset = "0x80EA120", VA = "0x1880EB520", Slot = "22")]
		public void OLWPIMMGHES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x80EBC10", Offset = "0x80EA810", VA = "0x1880EBC10", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80EC300", Offset = "0x80EAF00", VA = "0x1880EC300", Slot = "25")]
		public void YZPJIIJWEZZ(int a, DFHWJYQWSIY b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80EBD70", Offset = "0x80EA970", VA = "0x1880EBD70", Slot = "26")]
		public void TMRQXULMYYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80EABE0", Offset = "0x80E97E0", VA = "0x1880EABE0", Slot = "27")]
		public void AVSXCCHUWJH(int a, DFHWJYQWSIY b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80EB120", Offset = "0x80E9D20", VA = "0x1880EB120", Slot = "28")]
		public void FMHPIYZFXFZ(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80EB750", Offset = "0x80EA350", VA = "0x1880EB750", Slot = "31")]
		public void SHPZXJCSYZC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80EBF00", Offset = "0x80EAB00", VA = "0x1880EBF00", Slot = "29")]
		public void VWCLJVCMNJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x80EB560", Offset = "0x80EA160", VA = "0x1880EB560", Slot = "30")]
		public void SBARDRNBLRP(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80EB330", Offset = "0x80E9F30", VA = "0x1880EB330", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80EB200", Offset = "0x80E9E00", VA = "0x1880EB200", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCBFAD0", Offset = "0xCBE6D0", VA = "0x180CBFAD0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80EAFE0", Offset = "0x80E9BE0", VA = "0x1880EAFE0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, DFHWJYQWSIY otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "44")]
		public void ParentChanged(int slotIndex, DFHWJYQWSIY newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "45")]
		public void ChildAdded(int slotIndex, DFHWJYQWSIY newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "46")]
		public void ChildRemoved(int slotIndex, DFHWJYQWSIY removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "47")]
		public void ConnectionModified(int slotIndex, DFHWJYQWSIY parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x80EB540", Offset = "0x80EA140", VA = "0x1880EB540", Slot = "48")]
		public void RootChanged(DFHWJYQWSIY previousRootConnectable, DFHWJYQWSIY newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x80EBC60", Offset = "0x80EA860", VA = "0x1880EBC60", Slot = "23")]
		public void TFLGLTJQDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80EBEB0", Offset = "0x80EAAB0", VA = "0x1880EBEB0", Slot = "24")]
		public void UZORPHOVHSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80EB080", Offset = "0x80E9C80", VA = "0x1880EB080")]
		private void ECEFTOPJQGI(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(JBLZQQTZCEF), new string[] { })]
	public class ZKGJUYBUXCK : JBLZQQTZCEF, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OIJSTNCODXH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OIJSTNCODXH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private UBCETFOUJPT OKLMDKLKPBM;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object VOUBFKLSYDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x80F12A0", Offset = "0x80EFEA0", VA = "0x1880F12A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80F1250", Offset = "0x80EFE50", VA = "0x1880F1250", Slot = "5")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC6B6D0", Offset = "0xC6A2D0", VA = "0x180C6B6D0", Slot = "6")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZKGJUYBUXCK()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(YFCKQXWLECD), new string[] { "Ignore", "Mock" })]
	public class TZUHALFXYOI : YFCKQXWLECD, HJESUUHTFVQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool TDZVKIVXUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ICHPNQRFEJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY> IKRHSCWEONB
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x80EFC70", Offset = "0x80EE870", VA = "0x1880EFC70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x80EFD20", Offset = "0x80EE920", VA = "0x1880EFD20", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY> GBREVQGENKN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x80EFE80", Offset = "0x80EEA80", VA = "0x1880EFE80", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x80EFF30", Offset = "0x80EEB30", VA = "0x1880EFF30", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY, DFHWJYQWSIY> NGVLDMIMFYT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x80EFDD0", Offset = "0x80EE9D0", VA = "0x1880EFDD0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x80EFBC0", Offset = "0x80EE7C0", VA = "0x1880EFBC0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "26")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "12")]
		public void Initialize(GameObject gameObject, MXSTWLAKHDU configData, NFABTAFLYGJ rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "14")]
		public void OGBNJYRINGK(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "15")]
		public void WOWKLYECNPX(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "16")]
		public void TJHPKLXIWQG(DFHWJYQWSIY a, HashSet<DFHWJYQWSIY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "17")]
		public void ETSTOTSNQGM(DFHWJYQWSIY a, DFHWJYQWSIY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "18")]
		public void HFIRSBOBTQE(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "19")]
		public void YFUSJINKXJM(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "20")]
		public ConnectableGraphData FVMZWXRUVCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "21")]
		public ConnectableGraphData IFLDDBWRYXH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "22")]
		public bool NTPSUVFFPFF(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "23")]
		public void YKWCTAIAFFO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "24")]
		public void NDEVUCMFSHU(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "25")]
		public void XZEITTFGZDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public TZUHALFXYOI()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DFHWJYQWSIY : TKSCPDNTBON, IEquatable<DFHWJYQWSIY>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface TKSCPDNTBON
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		DFHWJYQWSIY ParentConnectable
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
		bool CanConnectTo(int slotIndex, DFHWJYQWSIY otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, DFHWJYQWSIY newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, DFHWJYQWSIY newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, DFHWJYQWSIY removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, DFHWJYQWSIY parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(DFHWJYQWSIY previousRootConnectable, DFHWJYQWSIY newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YFCKQXWLECD : HJESUUHTFVQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool TDZVKIVXUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICHPNQRFEJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<DFHWJYQWSIY, DFHWJYQWSIY> IKRHSCWEONB;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<DFHWJYQWSIY, DFHWJYQWSIY> GBREVQGENKN;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<DFHWJYQWSIY, DFHWJYQWSIY, DFHWJYQWSIY> NGVLDMIMFYT;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, MXSTWLAKHDU configData, NFABTAFLYGJ rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OGBNJYRINGK(DFHWJYQWSIY a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void WOWKLYECNPX(DFHWJYQWSIY a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void TJHPKLXIWQG(DFHWJYQWSIY a, HashSet<DFHWJYQWSIY> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ETSTOTSNQGM(DFHWJYQWSIY a, DFHWJYQWSIY b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void HFIRSBOBTQE(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void YFUSJINKXJM(DFHWJYQWSIY a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData FVMZWXRUVCH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData IFLDDBWRYXH(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool NTPSUVFFPFF(SQYEMCNRKEX a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YKWCTAIAFFO(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void NDEVUCMFSHU(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void XZEITTFGZDZ(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface PIZMEJFYCYZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DFHWJYQWSIY XXIXKCBDJZZ(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DFHWJYQWSIY AHXHZGBZTLE(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CCTDIXUKPSW(DFHWJYQWSIY a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool OWKLALJDIYO();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZOZHCHHVESV(DFHWJYQWSIY a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NOZHPTPGUVY
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HQIWCPIRRRA(AVNGAQRLRFM a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CJVWVTCNFSD(AVNGAQRLRFM a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string PAIUWTLPSSG(AVNGAQRLRFM a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid XXFMQGLMGXT(AVNGAQRLRFM a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int PXNTCBYCOQW(AVNGAQRLRFM a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EHJGMNPLWYV(AVNGAQRLRFM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(DFHWJYQWSIY childConnectable, int childConnectableSlot, DFHWJYQWSIY parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(DFHWJYQWSIY previousRootConnectable, DFHWJYQWSIY newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface AVNGAQRLRFM : DFHWJYQWSIY, TKSCPDNTBON, IEquatable<DFHWJYQWSIY>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AKLNJHSNXRK : TKSCPDNTBON
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		DFHWJYQWSIY JTLVMMHKTRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<DFHWJYQWSIY> OBMQCWKNLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 JXPMQGNLQBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion FGOUDLPGURO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool GYLHZJNGZOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IVDNCCDSNWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler LDTCTSNHCDD;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler ELYTWBYRPOX;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler PVWUWDIXKFS;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler OMCYRZNPIRJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VGJFGOFKCUR();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OLWPIMMGHES();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void TFLGLTJQDEH();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void UZORPHOVHSM();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void YZPJIIJWEZZ(int a, DFHWJYQWSIY b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void TMRQXULMYYH();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void AVSXCCHUWJH(int a, DFHWJYQWSIY b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void FMHPIYZFXFZ(DFHWJYQWSIY a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void VWCLJVCMNJQ();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void SBARDRNBLRP(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void SHPZXJCSYZC(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HUXBELZHCBW
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 ICKHZPOLEPJ
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
	public interface MXSTWLAKHDU
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool PPPNWIQTIEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		JIRDHHBJQJD EHLGLTLAFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, MXSTWLAKHDU
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
		public bool PPPNWIQTIEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xBAE8E0", Offset = "0xBAD4E0", VA = "0x180BAE8E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JIRDHHBJQJD EHLGLTLAFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x80DDDF0", Offset = "0x80DC9F0", VA = "0x1880DDDF0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x80DDEB0", Offset = "0x80DCAB0", VA = "0x1880DDEB0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DFHWJYQWSIY connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x80DE370", Offset = "0x80DCF70", VA = "0x1880DE370")]
		public ConnectableLink(DFHWJYQWSIY connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x80DE3D0", Offset = "0x80DCFD0", VA = "0x1880DE3D0")]
		public ConnectableLink(DFHWJYQWSIY connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x80DE470", Offset = "0x80DD070", VA = "0x1880DE470")]
		public ConnectableLink(DFHWJYQWSIY connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x80DDF00", Offset = "0x80DCB00", VA = "0x1880DDF00", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x80DDFB0", Offset = "0x80DCBB0", VA = "0x1880DDFB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : LMZWFQJWRLV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform DLNTDGFNFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JIRDHHBJQJD PRLZUHEZIMB;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A43580", Offset = "0x7A42180", VA = "0x187A43580", Slot = "4")]
		public void Initialize(Transform transform, JIRDHHBJQJD linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x80DF000", Offset = "0x80DDC00", VA = "0x1880DF000", Slot = "5")]
		public JIRDHHBJQJD ECNPIZFLCRJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x80DF0D0", Offset = "0x80DDCD0", VA = "0x1880DF0D0", Slot = "6")]
		public void GFXRRRKKEXV(JIRDHHBJQJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, VGJOIHYOMCT
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class RKLURCCFQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public DFHWJYQWSIY JCMOZTUSIBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public DFHWJYQWSIY UOBVGQWDNXJ;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public RKLURCCFQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x80EF0A0", Offset = "0x80EDCA0", VA = "0x1880EF0A0")]
			internal bool MOFWYBNNQGR(GUCAVTZONTS a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly YCJMXYBWKCZ WTUEGWPBMHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private SWOXDGMHBKY KSPJGLXPVPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NIRWXHSWOMY FXQWUGMRPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool RSXKDPYOAVG;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log HOYGASEDDIW;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public GUCAVTZONTS TEDROYGXZDB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80E0920", Offset = "0x80DF520", VA = "0x1880E0920")]
		public bool NVEKBGKKHPG([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80E18E0", Offset = "0x80E04E0", VA = "0x1880E18E0")]
		private bool PUHBVQJRWRR([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80E2D10", Offset = "0x80E1910", VA = "0x1880E2D10")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80E0930", Offset = "0x80DF530", VA = "0x1880E0930", Slot = "5")]
		public void Initialize(YFCKQXWLECD manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80E1680", Offset = "0x80E0280", VA = "0x1880E1680", Slot = "17")]
		public void PBXJTCBANRH(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80E2120", Offset = "0x80E0D20", VA = "0x1880E2120", Slot = "12")]
		public void ROZIUXRNHKA(Func<DFHWJYQWSIY, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x80E2130", Offset = "0x80E0D30", VA = "0x1880E2130")]
		private void ROZIUXRNHKA(YCJMXYBWKCZ a, Func<DFHWJYQWSIY, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80E2710", Offset = "0x80E1310", VA = "0x1880E2710", Slot = "11")]
		public void YAGKWWMLKNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x80E2850", Offset = "0x80E1450", VA = "0x1880E2850", Slot = "8")]
		public bool ZBWZGBHPTIR(DFHWJYQWSIY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x80DFA50", Offset = "0x80DE650", VA = "0x1880DFA50")]
		private bool AJQPHHAOBKG(DFHWJYQWSIY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x80E0F80", Offset = "0x80DFB80", VA = "0x1880E0F80")]
		private static bool KHCCCSACVYE(DFHWJYQWSIY a, YCJMXYBWKCZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x80E2860", Offset = "0x80E1460", VA = "0x1880E2860")]
		private void ZRQQLUQBUKC(Transform a, YCJMXYBWKCZ b, YCJMXYBWKCZ[] c, DFHWJYQWSIY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x80E07D0", Offset = "0x80DF3D0", VA = "0x1880E07D0")]
		private ConnectableLink GYPQXRVEORB(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x80E03B0", Offset = "0x80DEFB0", VA = "0x1880E03B0")]
		private static bool BHINPENNLBE(YCJMXYBWKCZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x80E0640", Offset = "0x80DF240", VA = "0x1880E0640", Slot = "9")]
		public bool CZMKRJVQJJX(DFHWJYQWSIY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x80E0160", Offset = "0x80DED60", VA = "0x1880E0160")]
		private bool APCBCCXSTCC(DFHWJYQWSIY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x80E13E0", Offset = "0x80DFFE0", VA = "0x1880E13E0")]
		private static void LVSTMKGBNFL(DFHWJYQWSIY a, int b, int c, Vector3 d, Quaternion e, YCJMXYBWKCZ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x80E2730", Offset = "0x80E1330", VA = "0x1880E2730")]
		private void YSLXPCLTZKO(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x80E1EA0", Offset = "0x80E0AA0", VA = "0x1880E1EA0")]
		private void QMLCNAFLGMS(YCJMXYBWKCZ a, DFHWJYQWSIY b, DFHWJYQWSIY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x80E1F10", Offset = "0x80E0B10", VA = "0x1880E1F10")]
		private void QMLCNAFLGMS(DFHWJYQWSIY a, DFHWJYQWSIY b, DFHWJYQWSIY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x80E1370", Offset = "0x80DFF70", VA = "0x1880E1370")]
		private void LULSJALRICT(DFHWJYQWSIY a, DFHWJYQWSIY b, DFHWJYQWSIY c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x80E1270", Offset = "0x80DFE70", VA = "0x1880E1270")]
		private void LULSJALRICT(YCJMXYBWKCZ a, DFHWJYQWSIY b, DFHWJYQWSIY c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x80E1560", Offset = "0x80E0160", VA = "0x1880E1560")]
		private void MSYHLHGKSMK(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x80E1780", Offset = "0x80E0380", VA = "0x1880E1780")]
		private void PDRSTUUGQWQ(GUCAVTZONTS a, GUCAVTZONTS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x80E1F80", Offset = "0x80E0B80", VA = "0x1880E1F80", Slot = "18")]
		public DFHWJYQWSIY QYWJMIRNIUN(DFHWJYQWSIY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x80E2260", Offset = "0x80E0E60", VA = "0x1880E2260", Slot = "13")]
		public void TJHPKLXIWQG(DFHWJYQWSIY a, HashSet<DFHWJYQWSIY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80E1030", Offset = "0x80DFC30", VA = "0x1880E1030", Slot = "14")]
		public List<DFHWJYQWSIY> LMUXYAEKIHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x80E0570", Offset = "0x80DF170", VA = "0x1880E0570")]
		protected GUCAVTZONTS BIECBJVAMAV(GUCAVTZONTS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x80DF950", Offset = "0x80DE550", VA = "0x1880DF950")]
		protected YCJMXYBWKCZ[] AAWQLJNZGXI(YCJMXYBWKCZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x80E2600", Offset = "0x80E1200", VA = "0x1880E2600")]
		protected bool WLTIZRFFWIT(DFHWJYQWSIY a, [Out] YCJMXYBWKCZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x80E06A0", Offset = "0x80DF2A0", VA = "0x1880E06A0", Slot = "15")]
		public bool DAXPPXVNKHR(DFHWJYQWSIY a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80E20E0", Offset = "0x80E0CE0", VA = "0x1880E20E0")]
		protected YCJMXYBWKCZ RIUWJXWFQXK(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x80DF9F0", Offset = "0x80DE5F0", VA = "0x1880DF9F0", Slot = "10")]
		public bool AFVYUHJWAGP(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x80E09E0", Offset = "0x80DF5E0", VA = "0x1880E09E0")]
		private bool JQBNXEGLEJM(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x80E16B0", Offset = "0x80E02B0", VA = "0x1880E16B0")]
		private static bool PCSYQRHVRWA(YCJMXYBWKCZ a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x80E0920", Offset = "0x80DF520", VA = "0x1880E0920", Slot = "7")]
		private bool IMAAYMITMJX([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : YFCKQXWLECD, HJESUUHTFVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly URVRSSRGCJF container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly NIRWXHSWOMY FXQWUGMRPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly BQGDPZNGCWJ ICVZOVPBOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly PSUMHRWTZZV KCOPALIWOVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly VGJOIHYOMCT NADPMOXTWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal XTLAOAEABII TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal QGYETPOUYFZ GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal SWOXDGMHBKY KUNJCKMEUVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool RSXKDPYOAVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool TOQEKGXHFUZ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool QAPLYMROFSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAE2290", Offset = "0xAE0E90", VA = "0x180AE2290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAE1D80", Offset = "0xAE0980", VA = "0x180AE1D80")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool TDZVKIVXUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x102BE50", Offset = "0x102AA50", VA = "0x18102BE50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x24F62B0", Offset = "0x24F4EB0", VA = "0x1824F62B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ICHPNQRFEJE
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY> IKRHSCWEONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x80E4220", Offset = "0x80E2E20", VA = "0x1880E4220", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x80E45C0", Offset = "0x80E31C0", VA = "0x1880E45C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY> GBREVQGENKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x80E4800", Offset = "0x80E3400", VA = "0x1880E4800", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x80E4860", Offset = "0x80E3460", VA = "0x1880E4860", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<DFHWJYQWSIY, DFHWJYQWSIY, DFHWJYQWSIY> NGVLDMIMFYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x80E4720", Offset = "0x80E3320", VA = "0x1880E4720", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x80E2EC0", Offset = "0x80E1AC0", VA = "0x1880E2EC0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x80E4B60", Offset = "0x80E3760", VA = "0x1880E4B60")]
		public LegacyConnectableManager(URVRSSRGCJF container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80E3B50", Offset = "0x80E2750", VA = "0x1880E3B50", Slot = "12")]
		public void Initialize(GameObject gameObject, MXSTWLAKHDU configData, NFABTAFLYGJ rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x80E43A0", Offset = "0x80E2FA0", VA = "0x1880E43A0", Slot = "26")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x80E4780", Offset = "0x80E3380", VA = "0x1880E4780", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x80E4380", Offset = "0x80E2F80", VA = "0x1880E4380", Slot = "14")]
		public void OGBNJYRINGK(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x80E3690", Offset = "0x80E2290", VA = "0x1880E3690", Slot = "15")]
		public void WOWKLYECNPX(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x80E4330", Offset = "0x80E2F30", VA = "0x1880E4330", Slot = "22")]
		public bool NTPSUVFFPFF(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x80E4110", Offset = "0x80E2D10", VA = "0x1880E4110")]
		internal bool JQBNXEGLEJM([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x80E4470", Offset = "0x80E3070", VA = "0x1880E4470")]
		internal bool QIOABZBQHKA([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80E3050", Offset = "0x80E1C50", VA = "0x1880E3050")]
		internal void EMPDIBBISGI(DFHWJYQWSIY a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x80E3690", Offset = "0x80E2290", VA = "0x1880E3690")]
		internal bool FHFGTFNJPZA(DFHWJYQWSIY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x80E2F20", Offset = "0x80E1B20", VA = "0x1880E2F20")]
		internal bool CPVGPYOJEGU(DFHWJYQWSIY a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x80E4620", Offset = "0x80E3220", VA = "0x1880E4620", Slot = "16")]
		public void TJHPKLXIWQG(DFHWJYQWSIY a, HashSet<DFHWJYQWSIY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x80E3230", Offset = "0x80E1E30", VA = "0x1880E3230", Slot = "17")]
		public void ETSTOTSNQGM(DFHWJYQWSIY a, DFHWJYQWSIY b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x80E3870", Offset = "0x80E2470", VA = "0x1880E3870", Slot = "18")]
		public void HFIRSBOBTQE(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x80E4900", Offset = "0x80E3500", VA = "0x1880E4900", Slot = "19")]
		public void YFUSJINKXJM(DFHWJYQWSIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x80E3440", Offset = "0x80E2040", VA = "0x1880E3440")]
		public void EWNWOKNVXTB([Optional] HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x80E4AD0", Offset = "0x80E36D0", VA = "0x1880E4AD0", Slot = "23")]
		public void YKWCTAIAFFO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x80E36F0", Offset = "0x80E22F0", VA = "0x1880E36F0", Slot = "20")]
		public ConnectableGraphData FVMZWXRUVCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x80E39B0", Offset = "0x80E25B0", VA = "0x1880E39B0", Slot = "21")]
		public ConnectableGraphData IFLDDBWRYXH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x80E48C0", Offset = "0x80E34C0", VA = "0x1880E48C0", Slot = "25")]
		public void XZEITTFGZDZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x80E4280", Offset = "0x80E2E80", VA = "0x1880E4280", Slot = "24")]
		public void NDEVUCMFSHU(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class NIRWXHSWOMY : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly NXHZRCKDQAN<DFHWJYQWSIY, DFHWJYQWSIY> IKRHSCWEONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly NXHZRCKDQAN<DFHWJYQWSIY, DFHWJYQWSIY> GBREVQGENKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly NXCSTVQGGPE<DFHWJYQWSIY, DFHWJYQWSIY, DFHWJYQWSIY> NGVLDMIMFYT;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x80E5F50", Offset = "0x80E4B50", VA = "0x1880E5F50")]
		public NIRWXHSWOMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80E5EF0", Offset = "0x80E4AF0", VA = "0x1880E5EF0")]
		public void ZDLAPUVGJBV(DFHWJYQWSIY a, DFHWJYQWSIY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x80E5E10", Offset = "0x80E4A10", VA = "0x1880E5E10")]
		public void BKUQDOZOSCR(DFHWJYQWSIY a, DFHWJYQWSIY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x80E5E70", Offset = "0x80E4A70", VA = "0x1880E5E70")]
		public void KKDOKVNRJWH(DFHWJYQWSIY a, DFHWJYQWSIY b, DFHWJYQWSIY c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class BQGDPZNGCWJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager KKNCQNIOILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private QGYETPOUYFZ GWUBCTSVVBD;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public BQGDPZNGCWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x80DDA10", Offset = "0x80DC610", VA = "0x1880DDA10")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x80DDA00", Offset = "0x80DC600", VA = "0x1880DDA00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x80DDBB0", Offset = "0x80DC7B0", VA = "0x1880DDBB0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x80DDB40", Offset = "0x80DC740", VA = "0x1880DDB40")]
		private void OnMasterClientSwitched(HNNNRVHBOIU newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x80DDBF0", Offset = "0x80DC7F0", VA = "0x1880DDBF0")]
		public void PIPCSJZVEXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x80DDCF0", Offset = "0x80DC8F0", VA = "0x1880DDCF0")]
		public void THUVFWMCVEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class WCXVLIHWHNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public URVRSSRGCJF container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x80DE6E0", Offset = "0x80DD2E0", VA = "0x1880DE6E0")]
			internal LegacyConnectableManager JBTXQLUACLG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x80F0260", Offset = "0x80EEE60", VA = "0x1880F0260")]
		public static void PWYMCPSVMUA(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x80F01E0", Offset = "0x80EEDE0", VA = "0x1880F01E0")]
		public static void BVYEIGEQWVJ(URVRSSRGCJF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, SWOXDGMHBKY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, JIRDHHBJQJD> STLSNTFNOIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation JVCQFULLYRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private LMZWFQJWRLV JNFSWWEOGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private VGJOIHYOMCT NADPMOXTWEN;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker MZBSQEMSXOX;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x80E5BB0", Offset = "0x80E47B0", VA = "0x1880E5BB0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x80E5810", Offset = "0x80E4410", VA = "0x1880E5810", Slot = "7")]
		public void Initialize(VGJOIHYOMCT graph, LMZWFQJWRLV creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x80E5570", Offset = "0x80E4170", VA = "0x1880E5570", Slot = "5")]
		public void IYFXAYXCOVK(GUCAVTZONTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80E5240", Offset = "0x80E3E40", VA = "0x1880E5240", Slot = "9")]
		public void GQUYHWFRGZZ(GUCAVTZONTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x80E53B0", Offset = "0x80E3FB0", VA = "0x1880E53B0", Slot = "8")]
		public void HKLSRIHJRQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x80E4EF0", Offset = "0x80E3AF0", VA = "0x1880E4EF0", Slot = "10")]
		public void FNBCAGQZCTS(GUCAVTZONTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x80E5850", Offset = "0x80E4450", VA = "0x1880E5850", Slot = "11")]
		public void QLAYQEOTISU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x80E59A0", Offset = "0x80E45A0", VA = "0x1880E59A0")]
		private bool ZNLBKXXSPFV(GUCAVTZONTS a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class PSUMHRWTZZV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly YCJMXYBWKCZ currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly SQYEMCNRKEX parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly SQYEMCNRKEX rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool RCXJJTCBYXG
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x80EF700", Offset = "0x80EE300", VA = "0x1880EF700")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x80EFB50", Offset = "0x80EE750", VA = "0x1880EFB50")]
			public SerializeNodeInSubgraph(YCJMXYBWKCZ currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] SQYEMCNRKEX parentNodeData, [Optional] SQYEMCNRKEX rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x80EF2A0", Offset = "0x80EDEA0", VA = "0x1880EF2A0")]
			public SQYEMCNRKEX DKWNNTIDYNZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x80EF440", Offset = "0x80EE040", VA = "0x1880EF440")]
			private SQYEMCNRKEX IZHKWLVRHCL([Out] SQYEMCNRKEX a, [Out] SQYEMCNRKEX b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x80EF500", Offset = "0x80EE100", VA = "0x1880EF500")]
			private SQYEMCNRKEX NFZWHROVTRH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x80EF820", Offset = "0x80EE420", VA = "0x1880EF820")]
			private void OHZWNQOLNPF(SQYEMCNRKEX a, SQYEMCNRKEX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x80EF990", Offset = "0x80EE590", VA = "0x1880EF990")]
			private void ZOSWGQFJLIY(SQYEMCNRKEX a, SQYEMCNRKEX b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager KKNCQNIOILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private VGJOIHYOMCT NADPMOXTWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private SWOXDGMHBKY KSPJGLXPVPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private QGYETPOUYFZ GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool HXOJHTUYRID;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool JJPKLUSWONC
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x80ECD30", Offset = "0x80EB930", VA = "0x1880ECD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool QAPLYMROFSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x80EE0D0", Offset = "0x80ECCD0", VA = "0x1880EE0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x80EE0B0", Offset = "0x80ECCB0", VA = "0x1880EE0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x80ED990", Offset = "0x80EC590", VA = "0x1880ED990")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x80ECDA0", Offset = "0x80EB9A0", VA = "0x1880ECDA0")]
		public ConnectableGraphData FVMZWXRUVCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x80ED3B0", Offset = "0x80EBFB0", VA = "0x1880ED3B0")]
		public ConnectableGraphData IFLDDBWRYXH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x80EEFA0", Offset = "0x80EDBA0", VA = "0x1880EEFA0")]
		public void YKWCTAIAFFO(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x80EDD80", Offset = "0x80EC980", VA = "0x1880EDD80")]
		public void NDEVUCMFSHU(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x80EC9C0", Offset = "0x80EB5C0", VA = "0x1880EC9C0")]
		public void BAKTBFHQIBK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x80EE380", Offset = "0x80ECF80", VA = "0x1880EE380")]
		private void PYCAZIDNAMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x80ED5E0", Offset = "0x80EC1E0", VA = "0x1880ED5E0")]
		private SQYEMCNRKEX IWIYTHUZLEH(YCJMXYBWKCZ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x80EEBD0", Offset = "0x80ED7D0", VA = "0x1880EEBD0")]
		private static void WCMYYYKVPTJ(YCJMXYBWKCZ a, bool b, SQYEMCNRKEX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x80ECF10", Offset = "0x80EBB10", VA = "0x1880ECF10")]
		private void HBHLYVZYTZC(YCJMXYBWKCZ a, bool b, SQYEMCNRKEX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x80ED550", Offset = "0x80EC150", VA = "0x1880ED550")]
		private SQYEMCNRKEX IVCTUAWFNIF(YCJMXYBWKCZ a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x80EE0F0", Offset = "0x80ECCF0", VA = "0x1880EE0F0")]
		private bool PNEDIZILQUN(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x80EE560", Offset = "0x80ED160", VA = "0x1880EE560")]
		private bool TWMEHEZNEJK(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x80ECD80", Offset = "0x80EB980", VA = "0x1880ECD80")]
		private bool FRIXMGZPRDQ(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x80EDA00", Offset = "0x80EC600", VA = "0x1880EDA00")]
		private static bool JFNTSFFOTBJ(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x80EDE20", Offset = "0x80ECA20", VA = "0x1880EDE20")]
		public static bool NTPSUVFFPFF(SQYEMCNRKEX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x80EC9F0", Offset = "0x80EB5F0", VA = "0x1880EC9F0")]
		private DFHWJYQWSIY DLOIYNWXVHT(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x80EEE20", Offset = "0x80EDA20", VA = "0x1880EEE20")]
		private DFHWJYQWSIY XXIXKCBDJZZ(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80ED220", Offset = "0x80EBE20", VA = "0x1880ED220")]
		private DFHWJYQWSIY HWTKNUYMPYS(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x80E6D80", Offset = "0x80E5980", VA = "0x1880E6D80")]
		private static Guid FJKDLLFIKDC(SQYEMCNRKEX a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x80ED130", Offset = "0x80EBD30", VA = "0x1880ED130")]
		private string HWGLYPLNKWR(SQYEMCNRKEX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x80ED800", Offset = "0x80EC400", VA = "0x1880ED800")]
		private bool IXJTDFTPJGI(YCJMXYBWKCZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x80EDB20", Offset = "0x80EC720", VA = "0x1880EDB20")]
		private static void KLYAXNXYVRI(YCJMXYBWKCZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public PSUMHRWTZZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public DFHWJYQWSIY child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public DFHWJYQWSIY parent;

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
		public ConnectableLink UDPBPXIMOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x80DE500", Offset = "0x80DD100", VA = "0x1880DE500")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink YFRWHWYBOHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x80DE5A0", Offset = "0x80DD1A0", VA = "0x1880DE5A0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x80DE5D0", Offset = "0x80DD1D0", VA = "0x1880DE5D0")]
		public ConnectionOperationData(DFHWJYQWSIY child, DFHWJYQWSIY parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface VGJOIHYOMCT
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		GUCAVTZONTS TEDROYGXZDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(YFCKQXWLECD manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool NVEKBGKKHPG([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZBWZGBHPTIR(DFHWJYQWSIY a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CZMKRJVQJJX(DFHWJYQWSIY a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AFVYUHJWAGP(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YAGKWWMLKNW();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ROZIUXRNHKA(Func<DFHWJYQWSIY, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TJHPKLXIWQG(DFHWJYQWSIY a, HashSet<DFHWJYQWSIY> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<DFHWJYQWSIY> LMUXYAEKIHQ();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DAXPPXVNKHR(DFHWJYQWSIY a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void PBXJTCBANRH(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(GUCAVTZONTS node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface GUCAVTZONTS
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		DFHWJYQWSIY QOQMRDBQZSP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		GUCAVTZONTS HOTTRVHGDFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink QPDMHSGWQXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool MJLDBHWBWUP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface JIRDHHBJQJD : KJWCVKLQHST.HGVQICUHFYR
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NXLLWCOSNCZ(DFHWJYQWSIY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XJOIHRCMFTT(DFHWJYQWSIY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PGNMUSERVPU(DFHWJYQWSIY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ETSGLGACUZU(DFHWJYQWSIY a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		JIRDHHBJQJD PCFKTHBRAYF(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface LMZWFQJWRLV
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, JIRDHHBJQJD linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JIRDHHBJQJD ECNPIZFLCRJ();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GFXRRRKKEXV(JIRDHHBJQJD a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface XTLAOAEABII : PIZMEJFYCYZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GCUKHHGYFKK();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BAFPPJTZMUH(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface SWOXDGMHBKY
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IYFXAYXCOVK(GUCAVTZONTS a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(VGJOIHYOMCT graph, LMZWFQJWRLV linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HKLSRIHJRQV();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GQUYHWFRGZZ(GUCAVTZONTS a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FNBCAGQZCTS(GUCAVTZONTS a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QLAYQEOTISU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class YCJMXYBWKCZ : GUCAVTZONTS
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class SAVXFFUMWUZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink ZTWVSDGWZWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public YCJMXYBWKCZ XSKEHJHMHAV;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SAVXFFUMWUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x80EF160", Offset = "0x80EDD60", VA = "0x1880EF160")]
			internal bool YLEUJJMTRGI(GUCAVTZONTS a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink GWSZNSYRHYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<YCJMXYBWKCZ> QSJZUDKWBZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private YCJMXYBWKCZ TPULVFXUKTS;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink QPDMHSGWQXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x46B2E70", Offset = "0x46B1A70", VA = "0x1846B2E70", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x80F0EC0", Offset = "0x80EFAC0", VA = "0x1880F0EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private YCJMXYBWKCZ NEAVNSGBNPF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x80F0460", Offset = "0x80EF060", VA = "0x1880F0460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public GUCAVTZONTS HOTTRVHGDFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DFHWJYQWSIY QOQMRDBQZSP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool MJLDBHWBWUP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x80F06B0", Offset = "0x80EF2B0", VA = "0x1880F06B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool OQJMZVGHEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x80F06C0", Offset = "0x80EF2C0", VA = "0x1880F06C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected YCJMXYBWKCZ CEBPHRDGBWL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x80F0690", Offset = "0x80EF290", VA = "0x1880F0690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x80F0EF0", Offset = "0x80EFAF0", VA = "0x1880F0EF0")]
		public YCJMXYBWKCZ(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x80F0710", Offset = "0x80EF310", VA = "0x1880F0710")]
		public YCJMXYBWKCZ NASCVWANXKQ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x80F0D40", Offset = "0x80EF940", VA = "0x1880F0D40")]
		public YCJMXYBWKCZ WQVKDDPMXAY(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x80F0AB0", Offset = "0x80EF6B0", VA = "0x1880F0AB0")]
		public YCJMXYBWKCZ Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x80F0540", Offset = "0x80EF140", VA = "0x1880F0540")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x80F0C90", Offset = "0x80EF890", VA = "0x1880F0C90")]
		public YCJMXYBWKCZ Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x80F0860", Offset = "0x80EF460", VA = "0x1880F0860")]
		private static void PBXJTCBANRH(YCJMXYBWKCZ a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x80F0850", Offset = "0x80EF450", VA = "0x1880F0850", Slot = "9")]
		public void PBXJTCBANRH(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x80F09C0", Offset = "0x80EF5C0", VA = "0x1880F09C0")]
		public static YCJMXYBWKCZ RIUWJXWFQXK(YCJMXYBWKCZ a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface QGYETPOUYFZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool JJPKLUSWONC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> SUORZUTBPGM;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<HNNNRVHBOIU> WBSPSRGUJFI;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NXLLWCOSNCZ(LegacyConnectableManager a, NFABTAFLYGJ b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ETSTOTSNQGM(DFHWJYQWSIY a, DFHWJYQWSIY b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void HFIRSBOBTQE(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LOPHQTIMIXH(ConnectableGraphData a, [Optional] HNNNRVHBOIU b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class NKSZDPSQDIL
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x80E60F0", Offset = "0x80E4CF0", VA = "0x1880E60F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object PGFSJHGESKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x80E60B0", Offset = "0x80E4CB0", VA = "0x1880E60B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x80E6050", Offset = "0x80E4C50", VA = "0x1880E6050")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class ALXCJDDBUNW : QGYETPOUYFZ, IDisposable, HMUXYZFPCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager KKNCQNIOILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private NFABTAFLYGJ PYQXBYNJZSB;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JJPKLUSWONC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x80DCC70", Offset = "0x80DB870", VA = "0x1880DCC70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x80DCAC0", Offset = "0x80DB6C0", VA = "0x1880DCAC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView ZZEZRYREMMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x80DCF10", Offset = "0x80DBB10", VA = "0x1880DCF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> SUORZUTBPGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x80DD960", Offset = "0x80DC560", VA = "0x1880DD960", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x80DD780", Offset = "0x80DC380", VA = "0x1880DD780", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<HNNNRVHBOIU> WBSPSRGUJFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x80DD8C0", Offset = "0x80DC4C0", VA = "0x1880DD8C0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x80DD820", Offset = "0x80DC420", VA = "0x1880DD820", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x80DCFA0", Offset = "0x80DBBA0", VA = "0x1880DCFA0", Slot = "10")]
		public void NXLLWCOSNCZ(LegacyConnectableManager a, NFABTAFLYGJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x80DCB00", Offset = "0x80DB700", VA = "0x1880DCB00", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x80DCB50", Offset = "0x80DB750", VA = "0x1880DCB50", Slot = "11")]
		public void ETSTOTSNQGM(DFHWJYQWSIY a, DFHWJYQWSIY b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x80DCCD0", Offset = "0x80DB8D0", VA = "0x1880DCCD0", Slot = "12")]
		public void HFIRSBOBTQE(DFHWJYQWSIY a, int b, DFHWJYQWSIY c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x80DCDF0", Offset = "0x80DB9F0", VA = "0x1880DCDF0", Slot = "13")]
		public void LOPHQTIMIXH(ConnectableGraphData a, [Optional] HNNNRVHBOIU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x80DD260", Offset = "0x80DBE60", VA = "0x1880DD260")]
		[RPCMethod]
		private void RpcMasterReparentNodes(DFHWJYQWSIY objectToReparent, int objectToReparentSlotIndex, DFHWJYQWSIY newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x80DD070", Offset = "0x80DBC70", VA = "0x1880DD070")]
		[RPCMethod]
		private void RpcMasterModifyNode(DFHWJYQWSIY connectableToModify, DFHWJYQWSIY expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x80DD650", Offset = "0x80DC250", VA = "0x1880DD650")]
		[RPCMethod]
		private void RpcReparentNodes(DFHWJYQWSIY objectToReparent, int objectToReparentSlotIndex, DFHWJYQWSIY newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x80DD560", Offset = "0x80DC160", VA = "0x1880DD560")]
		[RPCMethod]
		private void RpcModifyNode(DFHWJYQWSIY connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80DD030", Offset = "0x80DBC30", VA = "0x1880DD030")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ALXCJDDBUNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JIRDHHBJQJD, KJWCVKLQHST.HGVQICUHFYR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x80DF490", Offset = "0x80DE090", VA = "0x1880DF490", Slot = "4")]
		private void AUQEKVKJBVW(DFHWJYQWSIY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x80DF610", Offset = "0x80DE210", VA = "0x1880DF610", Slot = "5")]
		private void HUOEIVWNVKE(DFHWJYQWSIY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x80DF140", Offset = "0x80DDD40", VA = "0x1880DF140", Slot = "6")]
		private void AENFOGDXRQZ(DFHWJYQWSIY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x80DF2A0", Offset = "0x80DDEA0", VA = "0x1880DF2A0", Slot = "7")]
		private void AJVLGGMVUWL(DFHWJYQWSIY a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x80DF880", Offset = "0x80DE480", VA = "0x1880DF880", Slot = "8")]
		private JIRDHHBJQJD NJWACIQNABU(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x80DF8F0", Offset = "0x80DE4F0", VA = "0x1880DF8F0", Slot = "9")]
		private void PJOIWEVMWQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class FEOLOFRDWMR
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x367C740", Offset = "0x367B340", VA = "0x18367C740")]
		public static RHTOGEKRYDU<a> DJPCVVQDGZD<a>(this URVRSSRGCJF a)
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
