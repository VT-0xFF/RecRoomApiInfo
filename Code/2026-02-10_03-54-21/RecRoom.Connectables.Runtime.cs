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
		[Cpp2IlInjected.Address(RVA = "0x834CF00", Offset = "0x834C100", VA = "0x18834CF00", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		private int[] ECEPPZWRAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] ECJWNGQOJXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset ROOEZRYFVRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset ROIYCLEIMGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5840", Offset = "0x1FC4A40", VA = "0x181FC5840", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8358E60", Offset = "0x8358060", VA = "0x188358E60")]
		private void SZMWSWNXWRR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8358D10", Offset = "0x8357F10", VA = "0x188358D10")]
		private void SZHPVPUANGI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8358A00", Offset = "0x8357C00", VA = "0x188358A00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8358FB0", Offset = "0x83581B0", VA = "0x188358FB0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : BKCQYUFCVGG, AUDRUYSDRCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class TPYUZJRRQMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public WHUINJIFGJI LNDBWRIUHZK;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public TPYUZJRRQMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8355490", Offset = "0x8354690", VA = "0x188355490")]
			internal object JGTRIBMJUFB(WHUINJIFGJI a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class TQEBWQLOZXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public WHUINJIFGJI RCYTEZUPHFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TPYUZJRRQMA BXOYYNWATYZ;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public TQEBWQLOZXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8355500", Offset = "0x8354700", VA = "0x188355500")]
			internal object JGOKKUSMKTS((WHUINJIFGJI child, WHUINJIFGJI nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class TRZOWDBAZBR : IEnumerable<FAIXARNZTHF>, IEnumerable, IEnumerator<FAIXARNZTHF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private FAIXARNZTHF HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId NLIBQUPYCNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId YPQGGNYSMRX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private BFVRXAGRAXR YSLDUMLJJJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray NRGXETLRDYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator XPBWGTSVIRQ;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private FAIXARNZTHF HRBZMKRXBZH
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public TRZOWDBAZBR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8355740", Offset = "0x8354940", VA = "0x188355740", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x83558D0", Offset = "0x8354AD0", VA = "0x1883558D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8355C50", Offset = "0x8354E50", VA = "0x188355C50")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8355C30", Offset = "0x8354E30", VA = "0x188355C30")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8355C70", Offset = "0x8354E70", VA = "0x188355C70", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8355820", Offset = "0x8354A20", VA = "0x188355820", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FAIXARNZTHF> KSURMFVIUXY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8355820", Offset = "0x8354A20", VA = "0x188355820", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log GLMZJQHKIYL;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log QFMQFJNCVNZ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log FAUXORIEYYT;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log PVCGRHQRDKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NMGCCTMOOTM VETYNLMODYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ALHMQGDMQGN VZIPLRJOTWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ODVHAKGQADC XCQFQQLYWHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ADAVBWQOGDY NQFDUPPEUOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LMESXNYYZOK KNGMBCYXRHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HIQRBPEMDCO LFUSTJTQVQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly RMFDIRGCGLF APLQWVIUXCU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool UJRFHDXYQLF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAC49F0", Offset = "0xAC3BF0", VA = "0x180AC49F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAC4940", Offset = "0xAC3B40", VA = "0x180AC4940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KEUSZWEEBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF> WZWYBWUKFDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83512C0", Offset = "0x83504C0", VA = "0x1883512C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8350CB0", Offset = "0x834FEB0", VA = "0x188350CB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF> FIRFASYOKGE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8350FB0", Offset = "0x83501B0", VA = "0x188350FB0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x834F8B0", Offset = "0x834EAB0", VA = "0x18834F8B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF, FAIXARNZTHF> NSZKMKUHDCU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x834D8C0", Offset = "0x834CAC0", VA = "0x18834D8C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x834FD60", Offset = "0x834EF60", VA = "0x18834FD60", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8351E30", Offset = "0x8351030", VA = "0x188351E30")]
		public OMConnectableManager(CYZVJPHMMVM container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x834E3A0", Offset = "0x834D5A0", VA = "0x18834E3A0", Slot = "12")]
		public void Initialize(GameObject gameObject, LHAJDLYLFWF configData, DZCPLFMACGO sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8351500", Offset = "0x8350700", VA = "0x188351500", Slot = "26")]
		public void WZNPUCKKCSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x834E020", Offset = "0x834D220", VA = "0x18834E020", Slot = "22")]
		public bool FTLTVFCZUUE(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x834DE20", Offset = "0x834D020", VA = "0x18834DE20")]
		private void EBBGVUIJGVP(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x834E180", Offset = "0x834D380", VA = "0x18834E180")]
		private void HJBJLDTLVXV(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8351060", Offset = "0x8350260", VA = "0x188351060")]
		private void UNBYBGFVBNX(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x834D4B0", Offset = "0x834C6B0", VA = "0x18834D4B0")]
		private void AYDRVLXZSQG(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x834E610", Offset = "0x834D810", VA = "0x18834E610", Slot = "14")]
		public void JUFURAKXVZP(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "15")]
		public void UZTOMLDSUBY(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8351810", Offset = "0x8350A10", VA = "0x188351810", Slot = "17")]
		public void XDFQKTJZJHP(FAIXARNZTHF a, FAIXARNZTHF b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83516D0", Offset = "0x83508D0", VA = "0x1883516D0")]
		public void XDFQKTJZJHP(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x834F790", Offset = "0x834E990", VA = "0x18834F790")]
		public void NOWYLHPDANR(FAIXARNZTHF a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8351AB0", Offset = "0x8350CB0", VA = "0x188351AB0", Slot = "18")]
		public void YSHUKJFUDNB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x834F6E0", Offset = "0x834E8E0", VA = "0x18834F6E0")]
		private float NNBIWEGTXDD(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8351970", Offset = "0x8350B70", VA = "0x188351970")]
		public void YSHUKJFUDNB(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8350270", Offset = "0x834F470", VA = "0x188350270", Slot = "19")]
		public void SQXYEMVVMED(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x834FE70", Offset = "0x834F070", VA = "0x18834FE70", Slot = "16")]
		public void PZSXUQTNASB(FAIXARNZTHF a, HashSet<FAIXARNZTHF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "20")]
		public ConnectableGraphData NEDYPKOPQRY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "21")]
		public ConnectableGraphData XCLNYEKJJVE(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8350D60", Offset = "0x834FF60", VA = "0x188350D60", Slot = "23")]
		public void UBLUQDNXHPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8350200", Offset = "0x834F400", VA = "0x188350200", Slot = "24")]
		public void SORDSZCNNGH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8351C80", Offset = "0x8350E80", VA = "0x188351C80", Slot = "25")]
		public void ZMQCMXHAAUM(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x834F960", Offset = "0x834EB60", VA = "0x18834F960")]
		private void OFMLHZKIPHJ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83503E0", Offset = "0x834F5E0", VA = "0x1883503E0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8351C10", Offset = "0x8350E10", VA = "0x188351C10")]
		private void ZBBUXMSIDSI(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x834F820", Offset = "0x834EA20", VA = "0x18834F820")]
		[IteratorStateMachine(typeof(TRZOWDBAZBR))]
		public IEnumerable<FAIXARNZTHF> NQVOJXTZQHH(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x834D970", Offset = "0x834CB70", VA = "0x18834D970")]
		internal FAIXARNZTHF DZMWIGHQRFM(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8351370", Offset = "0x8350570", VA = "0x188351370")]
		internal ObjectLocalId VVJUZXAJHIK(FAIXARNZTHF a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x834E910", Offset = "0x834DB10", VA = "0x18834E910")]
		private bool KIVIWFYBAJR(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8350DD0", Offset = "0x834FFD0", VA = "0x188350DD0")]
		private bool UCUOIGZFVFZ(WHUINJIFGJI a, [Out] FAIXARNZTHF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x834DAA0", Offset = "0x834CCA0", VA = "0x18834DAA0")]
		private FAIXARNZTHF DZMWIGHQRFM(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8350E30", Offset = "0x8350030", VA = "0x188350E30")]
		private FAIXARNZTHF UDSHXWCUADZ(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x834F520", Offset = "0x834E720", VA = "0x18834F520")]
		private FAIXARNZTHF MTCJFYXBEUE(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8351CA0", Offset = "0x8350EA0", VA = "0x188351CA0")]
		private static Guid ZZEPNZOQKDT(WHUINJIFGJI a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x834F020", Offset = "0x834E220", VA = "0x18834F020")]
		private string LOSYYMDXHUQ(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x834EE90", Offset = "0x834E090", VA = "0x18834EE90")]
		private void LLXSADTGSTN(FAIXARNZTHF a, FAIXARNZTHF b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x834F390", Offset = "0x834E590", VA = "0x18834F390")]
		private void MQQPSTPDOKJ(FAIXARNZTHF a, FAIXARNZTHF b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x834FE10", Offset = "0x834F010", VA = "0x18834FE10")]
		private void PJKMGKJFQWP(FAIXARNZTHF a, FAIXARNZTHF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8350070", Offset = "0x834F270", VA = "0x188350070")]
		private void QCSREDBUFGG(FAIXARNZTHF a, FAIXARNZTHF b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x834E070", Offset = "0x834D270", VA = "0x18834E070")]
		private void HAJJFHNPFEP(ObjectLocalId a, FAIXARNZTHF b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x834F110", Offset = "0x834E310", VA = "0x18834F110")]
		private void LUFUAMVUCIU(ObjectLocalId a, FAIXARNZTHF b, FAIXARNZTHF c, FAIXARNZTHF d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZKOUBJZCYZL
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public CYZVJPHMMVM container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8358740", Offset = "0x8357940", VA = "0x188358740")]
			internal OMConnectableManager SHLEWRHTKTB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8358840", Offset = "0x8357A40", VA = "0x188358840")]
		public static void JSFPJKJBREL(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83589B0", Offset = "0x8357BB0", VA = "0x1883589B0")]
		public static void WUGAMPAPZSI(CYZVJPHMMVM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : RBXWDHZVMBZ, BWNBEBPIEOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx YRTMMJCFCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager NOSSIGJMYGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BVAGTLMEJJL VLVJBTDYMDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly YBFPJVAQSKP NQFDUPPEUOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly EVYHICLQBCH[] TDTOIFFOYNB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FAIXARNZTHF ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8353A30", Offset = "0x8352C30", VA = "0x188353A30", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FAIXARNZTHF OLLBLVGETPU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83526C0", Offset = "0x83518C0", VA = "0x1883526C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 ZEFTNDQPWAS
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8352E70", Offset = "0x8352070", VA = "0x188352E70", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion WYRYHZQGKOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8352ED0", Offset = "0x83520D0", VA = "0x188352ED0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DHKRXODAVVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8352DE0", Offset = "0x8351FE0", VA = "0x188352DE0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<FAIXARNZTHF> BYJHDOTSPUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8353290", Offset = "0x8352490", VA = "0x188353290", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool KIMLQCQISFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB3BBB0", Offset = "0xB3ADB0", VA = "0x180B3BBB0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC1B1F0", Offset = "0xC1A3F0", VA = "0x180C1B1F0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8353C30", Offset = "0x8352E30", VA = "0x188353C30", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8353950", Offset = "0x8352B50", VA = "0x188353950", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8353970", Offset = "0x8352B70", VA = "0x188353970", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8353A90", Offset = "0x8352C90", VA = "0x188353A90", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8353B70", Offset = "0x8352D70", VA = "0x188353B70", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool DYXYIVZUZXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8353240", Offset = "0x8352440", VA = "0x188353240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler JNPIMKQSCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83532C0", Offset = "0x83524C0", VA = "0x1883532C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8352340", Offset = "0x8351540", VA = "0x188352340", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler LBKDWFGAFVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83534D0", Offset = "0x83526D0", VA = "0x1883534D0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83521B0", Offset = "0x83513B0", VA = "0x1883521B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler RCUREKQZAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8352390", Offset = "0x8351590", VA = "0x188352390", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8352B90", Offset = "0x8351D90", VA = "0x188352B90", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler DKTVCKHWRTO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8353730", Offset = "0x8352930", VA = "0x188353730", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8352200", Offset = "0x8351400", VA = "0x188352200", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8353850", Offset = "0x8352A50", VA = "0x188353850")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, BVAGTLMEJJL connectableTool, EVYHICLQBCH[] connectionPoints, YBFPJVAQSKP callbacks, BKCQYUFCVGG connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8352180", Offset = "0x8351380", VA = "0x188352180", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "21")]
		public void MTAPVNQBIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8352E50", Offset = "0x8352050", VA = "0x188352E50", Slot = "22")]
		public void IFODBPWRMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83533B0", Offset = "0x83525B0", VA = "0x1883533B0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8353520", Offset = "0x8352720", VA = "0x188353520", Slot = "25")]
		public void YPZNOZHTOZY(int a, FAIXARNZTHF b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8353400", Offset = "0x8352600", VA = "0x188353400", Slot = "26")]
		public void TBRCGWMBMBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8351EA0", Offset = "0x83510A0", VA = "0x188351EA0", Slot = "27")]
		public void ACGPABVFLKQ(int a, FAIXARNZTHF b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8353330", Offset = "0x8352530", VA = "0x188353330", Slot = "28")]
		public void SINMDWSLEVY(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8352780", Offset = "0x8351980", VA = "0x188352780", Slot = "31")]
		public void GJIWUFCECLB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8352F30", Offset = "0x8352130", VA = "0x188352F30", Slot = "29")]
		public void JHSLPJNHNUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8352480", Offset = "0x8351680", VA = "0x188352480", Slot = "30")]
		public void FVLMXJYAMXE(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8352D10", Offset = "0x8351F10", VA = "0x188352D10", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8352BE0", Offset = "0x8351DE0", VA = "0x188352BE0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB1D930", Offset = "0xB1CB30", VA = "0x180B1D930", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83522A0", Offset = "0x83514A0", VA = "0x1883522A0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, FAIXARNZTHF otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "44")]
		public void ParentChanged(int slotIndex, FAIXARNZTHF newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "45")]
		public void ChildAdded(int slotIndex, FAIXARNZTHF newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "46")]
		public void ChildRemoved(int slotIndex, FAIXARNZTHF removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "47")]
		public void ConnectionModified(int slotIndex, FAIXARNZTHF parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8353310", Offset = "0x8352510", VA = "0x188353310", Slot = "48")]
		public void RootChanged(FAIXARNZTHF previousRootConnectable, FAIXARNZTHF newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8352430", Offset = "0x8351630", VA = "0x188352430", Slot = "23")]
		public void FRTWJQFGPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83523E0", Offset = "0x83515E0", VA = "0x1883523E0", Slot = "24")]
		public void EXTKSMBLHYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8352670", Offset = "0x8351870", VA = "0x188352670")]
		private void GDROVHZQTWV(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(TQMXXFVYCVY), new string[] { })]
	public class JLCPCRGVCPB : TQMXXFVYCVY, QJSYQBVQVWT, FCSNFFOEHRZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PLYECEGTBAG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PLYECEGTBAG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private XHBNAPDFPQW SERMBJTPEVP;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object YAQLPEPFRHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8345FD0", Offset = "0x83451D0", VA = "0x188345FD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8346060", Offset = "0x8345260", VA = "0x188346060", Slot = "5")]
		private void SZIMTXAXYAT(ANJPMPPNKBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xD065A0", Offset = "0xD057A0", VA = "0x180D065A0", Slot = "6")]
		private void BZXKCYDOFXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public JLCPCRGVCPB()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(BKCQYUFCVGG), new string[] { "Ignore", "Mock" })]
	public class MYYOPKGTWRF : BKCQYUFCVGG, AUDRUYSDRCN
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool UJRFHDXYQLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KEUSZWEEBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF> WZWYBWUKFDU
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x834D400", Offset = "0x834C600", VA = "0x18834D400", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x834D2A0", Offset = "0x834C4A0", VA = "0x18834D2A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF> FIRFASYOKGE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x834D350", Offset = "0x834C550", VA = "0x18834D350", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x834D140", Offset = "0x834C340", VA = "0x18834D140", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF, FAIXARNZTHF> NSZKMKUHDCU
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x834D090", Offset = "0x834C290", VA = "0x18834D090", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x834D1F0", Offset = "0x834C3F0", VA = "0x18834D1F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "26")]
		public void WZNPUCKKCSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "12")]
		public void Initialize(GameObject gameObject, LHAJDLYLFWF configData, DZCPLFMACGO rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "14")]
		public void JUFURAKXVZP(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "15")]
		public void UZTOMLDSUBY(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "16")]
		public void PZSXUQTNASB(FAIXARNZTHF a, HashSet<FAIXARNZTHF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "17")]
		public void XDFQKTJZJHP(FAIXARNZTHF a, FAIXARNZTHF b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "18")]
		public void YSHUKJFUDNB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "19")]
		public void SQXYEMVVMED(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "20")]
		public ConnectableGraphData NEDYPKOPQRY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "21")]
		public ConnectableGraphData XCLNYEKJJVE(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "22")]
		public bool FTLTVFCZUUE(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "23")]
		public void UBLUQDNXHPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "24")]
		public void SORDSZCNNGH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "25")]
		public void ZMQCMXHAAUM(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public MYYOPKGTWRF()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FAIXARNZTHF : BWNBEBPIEOW, IEquatable<FAIXARNZTHF>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BWNBEBPIEOW
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		FAIXARNZTHF ParentConnectable
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
		bool CanConnectTo(int slotIndex, FAIXARNZTHF otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, FAIXARNZTHF newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, FAIXARNZTHF newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, FAIXARNZTHF removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, FAIXARNZTHF parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(FAIXARNZTHF previousRootConnectable, FAIXARNZTHF newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BKCQYUFCVGG : AUDRUYSDRCN
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool UJRFHDXYQLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool KEUSZWEEBEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<FAIXARNZTHF, FAIXARNZTHF> WZWYBWUKFDU;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<FAIXARNZTHF, FAIXARNZTHF> FIRFASYOKGE;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<FAIXARNZTHF, FAIXARNZTHF, FAIXARNZTHF> NSZKMKUHDCU;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, LHAJDLYLFWF configData, DZCPLFMACGO rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JUFURAKXVZP(FAIXARNZTHF a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void UZTOMLDSUBY(FAIXARNZTHF a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void PZSXUQTNASB(FAIXARNZTHF a, HashSet<FAIXARNZTHF> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void XDFQKTJZJHP(FAIXARNZTHF a, FAIXARNZTHF b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YSHUKJFUDNB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void SQXYEMVVMED(FAIXARNZTHF a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData NEDYPKOPQRY(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData XCLNYEKJJVE(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool FTLTVFCZUUE(WHUINJIFGJI a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void UBLUQDNXHPV(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void SORDSZCNNGH(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ZMQCMXHAAUM(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ADAVBWQOGDY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FAIXARNZTHF MTCJFYXBEUE(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FAIXARNZTHF UDSHXWCUADZ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BIZJANEHTJJ(FAIXARNZTHF a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YROQJKFZLFD();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WCJIRNNVHWS(FAIXARNZTHF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YBFPJVAQSKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DYXYIVZUZXP(BVAGTLMEJJL a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QDVWGEJVNVS(BVAGTLMEJJL a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string GWSCNPAKXZF(BVAGTLMEJJL a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid VFBPQGIJENA(BVAGTLMEJJL a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int JQCFHNJVTIX(BVAGTLMEJJL a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YZWXXDUXKPI(BVAGTLMEJJL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(FAIXARNZTHF childConnectable, int childConnectableSlot, FAIXARNZTHF parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(FAIXARNZTHF previousRootConnectable, FAIXARNZTHF newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BVAGTLMEJJL : FAIXARNZTHF, BWNBEBPIEOW, IEquatable<FAIXARNZTHF>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface RBXWDHZVMBZ : BWNBEBPIEOW
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		FAIXARNZTHF OLLBLVGETPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<FAIXARNZTHF> BYJHDOTSPUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 ZEFTNDQPWAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion WYRYHZQGKOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool DHKRXODAVVX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool KIMLQCQISFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler JNPIMKQSCAI;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler LBKDWFGAFVE;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler RCUREKQZAFP;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler DKTVCKHWRTO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MTAPVNQBIEK();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void IFODBPWRMHB();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void FRTWJQFGPFG();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void EXTKSMBLHYH();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void YPZNOZHTOZY(int a, FAIXARNZTHF b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void TBRCGWMBMBU();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ACGPABVFLKQ(int a, FAIXARNZTHF b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void SINMDWSLEVY(FAIXARNZTHF a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void JHSLPJNHNUF();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void FVLMXJYAMXE(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void GJIWUFCECLB(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EVYHICLQBCH
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 PLIOCHTMKJI
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
	public interface LHAJDLYLFWF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool QZXJVPFLSCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ZCLHXELWHEC GZJPXICMELH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, LHAJDLYLFWF
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
		public bool QZXJVPFLSCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ZCLHXELWHEC GZJPXICMELH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83445A0", Offset = "0x83437A0", VA = "0x1883445A0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8344660", Offset = "0x8343860", VA = "0x188344660")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FAIXARNZTHF connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x8344B90", Offset = "0x8343D90", VA = "0x188344B90")]
		public ConnectableLink(FAIXARNZTHF connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8344BF0", Offset = "0x8343DF0", VA = "0x188344BF0")]
		public ConnectableLink(FAIXARNZTHF connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8344B10", Offset = "0x8343D10", VA = "0x188344B10")]
		public ConnectableLink(FAIXARNZTHF connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83446B0", Offset = "0x83438B0", VA = "0x1883446B0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8344760", Offset = "0x8343960", VA = "0x188344760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : DQKQDQYRIXU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform GCCZVOFBKEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ZCLHXELWHEC ZLRCDTZDCHM;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7C82A40", Offset = "0x7C81C40", VA = "0x187C82A40", Slot = "4")]
		public void Initialize(Transform transform, ZCLHXELWHEC linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8346190", Offset = "0x8345390", VA = "0x188346190", Slot = "5")]
		public ZCLHXELWHEC OZHNOJNYEOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8346120", Offset = "0x8345320", VA = "0x188346120", Slot = "6")]
		public void ASGSEMNANMW(ZCLHXELWHEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, VPJOQHERNCK
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class IGSPWWDJBIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public FAIXARNZTHF JODWBMXOCOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public FAIXARNZTHF QQRWJUUTOXO;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public IGSPWWDJBIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8345E40", Offset = "0x8345040", VA = "0x188345E40")]
			internal bool KEICAKFHOHU(JZXGQLBTEGZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly DKMIOIRRDNM TMTNLJVXUAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private OBOFCWTOAGB DMKJWOCYYWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private YVMIEQTZGQX JALGIVOOVFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool RENOTOCVIRJ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log OUEYMDNWVUF;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JZXGQLBTEGZ YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8349860", Offset = "0x8348A60", VA = "0x188349860")]
		public bool RWVDIHNJNAL([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8347680", Offset = "0x8346880", VA = "0x188347680")]
		private bool FAVCYYCEUUO([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8349EB0", Offset = "0x83490B0", VA = "0x188349EB0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8348170", Offset = "0x8347370", VA = "0x188348170", Slot = "5")]
		public void Initialize(BKCQYUFCVGG manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8349830", Offset = "0x8348A30", VA = "0x188349830", Slot = "17")]
		public void RVPZTWDMBMK(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83492C0", Offset = "0x83484C0", VA = "0x1883492C0", Slot = "12")]
		public void PIKGUQKHDLP(Func<FAIXARNZTHF, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8349190", Offset = "0x8348390", VA = "0x188349190")]
		private void PIKGUQKHDLP(DKMIOIRRDNM a, Func<FAIXARNZTHF, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8349960", Offset = "0x8348B60", VA = "0x188349960", Slot = "11")]
		public void UXMWTVQXIYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8349A60", Offset = "0x8348C60", VA = "0x188349A60", Slot = "8")]
		public bool WRRBINNSZGS(FAIXARNZTHF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83484B0", Offset = "0x83476B0", VA = "0x1883484B0")]
		private bool KZSMFCYRWLN(FAIXARNZTHF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8349870", Offset = "0x8348A70", VA = "0x188349870")]
		private static bool RZTSAEZRRTX(FAIXARNZTHF a, DKMIOIRRDNM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8347C90", Offset = "0x8346E90", VA = "0x188347C90")]
		private void HHKXXTCIDJX(Transform a, DKMIOIRRDNM b, DKMIOIRRDNM[] c, FAIXARNZTHF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8347420", Offset = "0x8346620", VA = "0x188347420")]
		private ConnectableLink DURVBBPRZZO(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8348220", Offset = "0x8347420", VA = "0x188348220")]
		private static bool JGUKXQZOHTR(DKMIOIRRDNM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8348110", Offset = "0x8347310", VA = "0x188348110", Slot = "9")]
		public bool ITBIRMXCQUO(FAIXARNZTHF a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8349B40", Offset = "0x8348D40", VA = "0x188349B40")]
		private bool YJXREDEAHKD(FAIXARNZTHF a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8348BC0", Offset = "0x8347DC0", VA = "0x188348BC0")]
		private static void LSZYVXMFYHU(FAIXARNZTHF a, int b, int c, Vector3 d, Quaternion e, DKMIOIRRDNM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8348AA0", Offset = "0x8347CA0", VA = "0x188348AA0")]
		private void LLXSADTGSTN(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8349980", Offset = "0x8348B80", VA = "0x188349980")]
		private void VDBTRAPDOTV(DKMIOIRRDNM a, FAIXARNZTHF b, FAIXARNZTHF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83499F0", Offset = "0x8348BF0", VA = "0x1883499F0")]
		private void VDBTRAPDOTV(FAIXARNZTHF a, FAIXARNZTHF b, FAIXARNZTHF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8348DA0", Offset = "0x8347FA0", VA = "0x188348DA0")]
		private void LUFUAMVUCIU(FAIXARNZTHF a, FAIXARNZTHF b, FAIXARNZTHF c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8348E10", Offset = "0x8348010", VA = "0x188348E10")]
		private void LUFUAMVUCIU(DKMIOIRRDNM a, FAIXARNZTHF b, FAIXARNZTHF c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8348F10", Offset = "0x8348110", VA = "0x188348F10")]
		private void MQQPSTPDOKJ(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83492D0", Offset = "0x83484D0", VA = "0x1883492D0")]
		private void PJKMGKJFQWP(JZXGQLBTEGZ a, JZXGQLBTEGZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8349030", Offset = "0x8348230", VA = "0x188349030", Slot = "18")]
		public FAIXARNZTHF NJAFOUPTSIK(FAIXARNZTHF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83494A0", Offset = "0x83486A0", VA = "0x1883494A0", Slot = "13")]
		public void PZSXUQTNASB(FAIXARNZTHF a, HashSet<FAIXARNZTHF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83471E0", Offset = "0x83463E0", VA = "0x1883471E0", Slot = "14")]
		public List<FAIXARNZTHF> DGICMNHVYBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x83483E0", Offset = "0x83475E0", VA = "0x1883483E0")]
		protected JZXGQLBTEGZ KDXOEXXXZDM(JZXGQLBTEGZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8348070", Offset = "0x8347270", VA = "0x188348070")]
		protected DKMIOIRRDNM[] ISPQSTZREQD(DKMIOIRRDNM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8347570", Offset = "0x8346770", VA = "0x188347570")]
		protected bool EKYRKWSLUOS(FAIXARNZTHF a, [Out] DKMIOIRRDNM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x83470B0", Offset = "0x83462B0", VA = "0x1883470B0", Slot = "15")]
		public bool BBTUFSHSNGS(FAIXARNZTHF a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8349920", Offset = "0x8348B20", VA = "0x188349920")]
		protected DKMIOIRRDNM TGEHZHMPRZZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8347C30", Offset = "0x8346E30", VA = "0x188347C30", Slot = "10")]
		public bool FPYWQGQOLQO(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8346B20", Offset = "0x8345D20", VA = "0x188346B20")]
		private bool APLTDNQGMOB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8349A70", Offset = "0x8348C70", VA = "0x188349A70")]
		private static bool XSYCVRKDKZR(DKMIOIRRDNM a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8349860", Offset = "0x8348A60", VA = "0x188349860", Slot = "7")]
		private bool WNQJESYVCCS([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : BKCQYUFCVGG, AUDRUYSDRCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly CYZVJPHMMVM container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly YVMIEQTZGQX JALGIVOOVFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly ADESVPWGIAE GFESLAHUAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly WVOZOAOWACK BZTREMVUEMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly VPJOQHERNCK PCRUSOVJGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal BUSLRLAWDBF NQFDUPPEUOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal LWPIQZSFGRO ZFWRMIZGFXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal OBOFCWTOAGB GEWXDYDLVUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool RENOTOCVIRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool ZJLJCVDLBGI;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MIBQUBSLVLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB03970", Offset = "0xB02B70", VA = "0x180B03970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB038B0", Offset = "0xB02AB0", VA = "0x180B038B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool UJRFHDXYQLF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x10C5A50", Offset = "0x10C4C50", VA = "0x1810C5A50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x25CB150", Offset = "0x25CA350", VA = "0x1825CB150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KEUSZWEEBEH
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF> WZWYBWUKFDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x834B680", Offset = "0x834A880", VA = "0x18834B680", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x834B4B0", Offset = "0x834A6B0", VA = "0x18834B4B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF> FIRFASYOKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x834B5A0", Offset = "0x834A7A0", VA = "0x18834B5A0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x834AF60", Offset = "0x834A160", VA = "0x18834AF60", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<FAIXARNZTHF, FAIXARNZTHF, FAIXARNZTHF> NSZKMKUHDCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x834A6F0", Offset = "0x83498F0", VA = "0x18834A6F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x834AFC0", Offset = "0x834A1C0", VA = "0x18834AFC0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x834BCE0", Offset = "0x834AEE0", VA = "0x18834BCE0")]
		public LegacyConnectableManager(CYZVJPHMMVM container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x834A7A0", Offset = "0x83499A0", VA = "0x18834A7A0", Slot = "12")]
		public void Initialize(GameObject gameObject, LHAJDLYLFWF configData, DZCPLFMACGO rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x834B6E0", Offset = "0x834A8E0", VA = "0x18834B6E0", Slot = "26")]
		public void WZNPUCKKCSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x834B600", Offset = "0x834A800", VA = "0x18834B600", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x834AD60", Offset = "0x8349F60", VA = "0x18834AD60", Slot = "14")]
		public void JUFURAKXVZP(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x834AD80", Offset = "0x8349F80", VA = "0x18834AD80", Slot = "15")]
		public void UZTOMLDSUBY(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x834A750", Offset = "0x8349950", VA = "0x18834A750", Slot = "22")]
		public bool FTLTVFCZUUE(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x834A060", Offset = "0x8349260", VA = "0x18834A060")]
		internal bool APLTDNQGMOB([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x834A5A0", Offset = "0x83497A0", VA = "0x18834A5A0")]
		internal bool BNSBPLJPRPJ([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x834A170", Offset = "0x8349370", VA = "0x18834A170")]
		internal void BAIPLBXLBBZ(FAIXARNZTHF a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x834AD80", Offset = "0x8349F80", VA = "0x18834AD80")]
		internal bool KGSMRYBDTPR(FAIXARNZTHF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x834B110", Offset = "0x834A310", VA = "0x18834B110")]
		internal bool SDNGPIJIMMN(FAIXARNZTHF a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x834B020", Offset = "0x834A220", VA = "0x18834B020", Slot = "16")]
		public void PZSXUQTNASB(FAIXARNZTHF a, HashSet<FAIXARNZTHF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x834B950", Offset = "0x834AB50", VA = "0x18834B950", Slot = "17")]
		public void XDFQKTJZJHP(FAIXARNZTHF a, FAIXARNZTHF b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x834BB60", Offset = "0x834AD60", VA = "0x18834BB60", Slot = "18")]
		public void YSHUKJFUDNB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x834B2F0", Offset = "0x834A4F0", VA = "0x18834B2F0", Slot = "19")]
		public void SQXYEMVVMED(FAIXARNZTHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x834A350", Offset = "0x8349550", VA = "0x18834A350")]
		public void BEGEERVGWDI([Optional] HJIMNRPSBJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x834B510", Offset = "0x834A710", VA = "0x18834B510", Slot = "23")]
		public void UBLUQDNXHPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x834ADE0", Offset = "0x8349FE0", VA = "0x18834ADE0", Slot = "20")]
		public ConnectableGraphData NEDYPKOPQRY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x834B7B0", Offset = "0x834A9B0", VA = "0x18834B7B0", Slot = "21")]
		public ConnectableGraphData XCLNYEKJJVE(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x834BCA0", Offset = "0x834AEA0", VA = "0x18834BCA0", Slot = "25")]
		public void ZMQCMXHAAUM(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x834B240", Offset = "0x834A440", VA = "0x18834B240", Slot = "24")]
		public void SORDSZCNNGH(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class YVMIEQTZGQX : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly KIGWPATEOSI<FAIXARNZTHF, FAIXARNZTHF> WZWYBWUKFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly KIGWPATEOSI<FAIXARNZTHF, FAIXARNZTHF> FIRFASYOKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly KIMDMHNBYDR<FAIXARNZTHF, FAIXARNZTHF, FAIXARNZTHF> NSZKMKUHDCU;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8358640", Offset = "0x8357840", VA = "0x188358640")]
		public YVMIEQTZGQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8358580", Offset = "0x8357780", VA = "0x188358580")]
		public void HZXOTSNPTZI(FAIXARNZTHF a, FAIXARNZTHF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83585E0", Offset = "0x83577E0", VA = "0x1883585E0")]
		public void IGDUEUFSMVG(FAIXARNZTHF a, FAIXARNZTHF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8358500", Offset = "0x8357700", VA = "0x188358500")]
		public void ABIQAUVTOAM(FAIXARNZTHF a, FAIXARNZTHF b, FAIXARNZTHF c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class ADESVPWGIAE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager JIYKLYRLQAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private LWPIQZSFGRO ZFWRMIZGFXU;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ADESVPWGIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83442E0", Offset = "0x83434E0", VA = "0x1883442E0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83441D0", Offset = "0x83433D0", VA = "0x1883441D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8344480", Offset = "0x8343680", VA = "0x188344480")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8344410", Offset = "0x8343610", VA = "0x188344410")]
		private void OnMasterClientSwitched(HJIMNRPSBJR newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83440D0", Offset = "0x83432D0", VA = "0x1883440D0")]
		public void BNKMSNFFXUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83441E0", Offset = "0x83433E0", VA = "0x1883441E0")]
		public void FJZBHGFZXHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FVNKOGXDRIC
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ZCFAVPDOUPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CYZVJPHMMVM container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ZCFAVPDOUPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x83587E0", Offset = "0x83579E0", VA = "0x1883587E0")]
			internal LegacyConnectableManager SHLEWRHTKTB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8345900", Offset = "0x8344B00", VA = "0x188345900")]
		public static void JSFPJKJBREL(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8345AF0", Offset = "0x8344CF0", VA = "0x188345AF0")]
		public static void WUGAMPAPZSI(CYZVJPHMMVM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, OBOFCWTOAGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, ZCLHXELWHEC> FBWHDDSFELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation NCNFSLMUJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private DQKQDQYRIXU QXUVCWKUTKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private VPJOQHERNCK PCRUSOVJGUI;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker MHOFJOAWKGC;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x834CE30", Offset = "0x834C030", VA = "0x18834CE30")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x834C850", Offset = "0x834BA50", VA = "0x18834C850", Slot = "7")]
		public void Initialize(VPJOQHERNCK graph, DQKQDQYRIXU creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x834C230", Offset = "0x834B430", VA = "0x18834C230", Slot = "5")]
		public void GHFKWYCTSXB(JZXGQLBTEGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x834CB90", Offset = "0x834BD90", VA = "0x18834CB90", Slot = "9")]
		public void ZEHDVNLSSRA(JZXGQLBTEGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x834C070", Offset = "0x834B270", VA = "0x18834C070", Slot = "8")]
		public void FJZLGILDKXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x834C600", Offset = "0x834B800", VA = "0x18834C600", Slot = "10")]
		public void IHVZDJZEAZP(JZXGQLBTEGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x834C890", Offset = "0x834BA90", VA = "0x18834C890", Slot = "11")]
		public void OJUESWAEPWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x834C9E0", Offset = "0x834BBE0", VA = "0x18834C9E0")]
		private bool UQKYXENHALO(JZXGQLBTEGZ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class WVOZOAOWACK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly DKMIOIRRDNM currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly WHUINJIFGJI parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly WHUINJIFGJI rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool HCSIYXYHFGF
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x8354D80", Offset = "0x8353F80", VA = "0x188354D80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8355420", Offset = "0x8354620", VA = "0x188355420")]
			public SerializeNodeInSubgraph(DKMIOIRRDNM currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] WHUINJIFGJI parentNodeData, [Optional] WHUINJIFGJI rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8354E90", Offset = "0x8354090", VA = "0x188354E90")]
			public WHUINJIFGJI JNXWDCMOQDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8355360", Offset = "0x8354560", VA = "0x188355360")]
			private WHUINJIFGJI ZIIVPLNSGLI([Out] WHUINJIFGJI a, [Out] WHUINJIFGJI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8354B80", Offset = "0x8353D80", VA = "0x188354B80")]
			private WHUINJIFGJI CVACZADMNPQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8355030", Offset = "0x8354230", VA = "0x188355030")]
			private void KFIZOIHNNHS(WHUINJIFGJI a, WHUINJIFGJI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x83551A0", Offset = "0x83543A0", VA = "0x1883551A0")]
			private void QBWCBHUTAND(WHUINJIFGJI a, WHUINJIFGJI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager JIYKLYRLQAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private VPJOQHERNCK PCRUSOVJGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private OBOFCWTOAGB DMKJWOCYYWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LWPIQZSFGRO ZFWRMIZGFXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool VXCQOTSAWNC;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool VYPEKZIVOSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8356580", Offset = "0x8355780", VA = "0x188356580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool MIBQUBSLVLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8358360", Offset = "0x8357560", VA = "0x188358360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8357710", Offset = "0x8356910", VA = "0x188357710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x83568F0", Offset = "0x8355AF0", VA = "0x1883568F0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8357210", Offset = "0x8356410", VA = "0x188357210")]
		public ConnectableGraphData NEDYPKOPQRY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83581C0", Offset = "0x83573C0", VA = "0x1883581C0")]
		public ConnectableGraphData XCLNYEKJJVE(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8357800", Offset = "0x8356A00", VA = "0x188357800")]
		public void UBLUQDNXHPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8357730", Offset = "0x8356930", VA = "0x188357730")]
		public void SORDSZCNNGH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83577D0", Offset = "0x83569D0", VA = "0x1883577D0")]
		public void TSFCIACQWRP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8357890", Offset = "0x8356A90", VA = "0x188357890")]
		private void VJYEKXNCKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8357630", Offset = "0x8356830", VA = "0x188357630")]
		private WHUINJIFGJI RWLSXLEKJZW(DKMIOIRRDNM a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8357C90", Offset = "0x8356E90", VA = "0x188357C90")]
		private static void WPXQGTERZYC(DKMIOIRRDNM a, bool b, WHUINJIFGJI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8357A70", Offset = "0x8356C70", VA = "0x188357A70")]
		private void VQNULQAZJQZ(DKMIOIRRDNM a, bool b, WHUINJIFGJI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8356860", Offset = "0x8355A60", VA = "0x188356860")]
		private WHUINJIFGJI GGCAFEBPKYA(DKMIOIRRDNM a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8357F40", Offset = "0x8357140", VA = "0x188357F40")]
		private bool WTBJVPIMFXI(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8356960", Offset = "0x8355B60", VA = "0x188356960")]
		private bool KIVIWFYBAJR(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8355EB0", Offset = "0x83550B0", VA = "0x188355EB0")]
		private bool APJBNBZCREZ(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8358380", Offset = "0x8357580", VA = "0x188358380")]
		private static bool YZPIBQWQSRG(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x83565D0", Offset = "0x83557D0", VA = "0x1883565D0")]
		public static bool FTLTVFCZUUE(WHUINJIFGJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8356250", Offset = "0x8355450", VA = "0x188356250")]
		private FAIXARNZTHF DZMWIGHQRFM(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83570A0", Offset = "0x83562A0", VA = "0x1883570A0")]
		private FAIXARNZTHF MTCJFYXBEUE(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8355ED0", Offset = "0x83550D0", VA = "0x188355ED0")]
		private FAIXARNZTHF ASSDCRTJFTJ(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8351CA0", Offset = "0x8350EA0", VA = "0x188351CA0")]
		private static Guid ZZEPNZOQKDT(WHUINJIFGJI a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8356FB0", Offset = "0x83561B0", VA = "0x188356FB0")]
		private string LOSYYMDXHUQ(WHUINJIFGJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8356060", Offset = "0x8355260", VA = "0x188356060")]
		private bool BBLPAPUUXSD(DKMIOIRRDNM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8357380", Offset = "0x8356580", VA = "0x188357380")]
		private static void PGBXSQMZHDN(DKMIOIRRDNM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public WVOZOAOWACK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public FAIXARNZTHF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FAIXARNZTHF parent;

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
		public ConnectableLink AEDBAEEWRNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8344CC0", Offset = "0x8343EC0", VA = "0x188344CC0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink GJIHMOJMSJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8344C90", Offset = "0x8343E90", VA = "0x188344C90")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8344D60", Offset = "0x8343F60", VA = "0x188344D60")]
		public ConnectionOperationData(FAIXARNZTHF child, FAIXARNZTHF parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface VPJOQHERNCK
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		JZXGQLBTEGZ YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(BKCQYUFCVGG manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RWVDIHNJNAL([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WRRBINNSZGS(FAIXARNZTHF a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ITBIRMXCQUO(FAIXARNZTHF a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FPYWQGQOLQO(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UXMWTVQXIYN();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PIKGUQKHDLP(Func<FAIXARNZTHF, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PZSXUQTNASB(FAIXARNZTHF a, HashSet<FAIXARNZTHF> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<FAIXARNZTHF> DGICMNHVYBD();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BBTUFSHSNGS(FAIXARNZTHF a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RVPZTWDMBMK(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(JZXGQLBTEGZ node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface JZXGQLBTEGZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		FAIXARNZTHF LDMDBNYBQFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		JZXGQLBTEGZ XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink JTSFHRPEDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool JSSAYGOZSCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface ZCLHXELWHEC : OTQATCHPJIK.PTNTGEMJGXK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MPSAKZMSCGK(FAIXARNZTHF a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NJMHFVROAGS(FAIXARNZTHF a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VERJFNIBBUP(FAIXARNZTHF a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MKLVGTOSKZH(FAIXARNZTHF a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZCLHXELWHEC WOEVWTABMRS(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface DQKQDQYRIXU
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, ZCLHXELWHEC linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZCLHXELWHEC OZHNOJNYEOI();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ASGSEMNANMW(ZCLHXELWHEC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface BUSLRLAWDBF : ADAVBWQOGDY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PXHYUFOSSBH();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZMLXUSCBWDK(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface OBOFCWTOAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GHFKWYCTSXB(JZXGQLBTEGZ a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(VPJOQHERNCK graph, DQKQDQYRIXU linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FJZLGILDKXW();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZEHDVNLSSRA(JZXGQLBTEGZ a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IHVZDJZEAZP(JZXGQLBTEGZ a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OJUESWAEPWN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class DKMIOIRRDNM : JZXGQLBTEGZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class FXCDCBLYXZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink ALTBXEOPBNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public DKMIOIRRDNM CYJFMVOVNKM;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public FXCDCBLYXZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8345B70", Offset = "0x8344D70", VA = "0x188345B70")]
			internal bool BOXQCLJOKHB(JZXGQLBTEGZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink YBLVNCIXWUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<DKMIOIRRDNM> ZXMFBABJTPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DKMIOIRRDNM DPWDHPWXWSV;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink JTSFHRPEDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4746E50", Offset = "0x4746050", VA = "0x184746E50", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8344DD0", Offset = "0x8343FD0", VA = "0x188344DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DKMIOIRRDNM NGCRDKEZGTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8344E10", Offset = "0x8344010", VA = "0x188344E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public JZXGQLBTEGZ XHHODTLVIQM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public FAIXARNZTHF LDMDBNYBQFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JSSAYGOZSCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8344E00", Offset = "0x8344000", VA = "0x188344E00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NLQQCRUCCTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8345300", Offset = "0x8344500", VA = "0x188345300", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected DKMIOIRRDNM OLVATFGKMBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8345840", Offset = "0x8344A40", VA = "0x188345840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8345860", Offset = "0x8344A60", VA = "0x188345860")]
		public DKMIOIRRDNM(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8345040", Offset = "0x8344240", VA = "0x188345040")]
		public DKMIOIRRDNM LEPZGRIDJSX(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8345180", Offset = "0x8344380", VA = "0x188345180")]
		public DKMIOIRRDNM PLCRAWVCCED(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x83454C0", Offset = "0x83446C0", VA = "0x1883454C0")]
		public DKMIOIRRDNM Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8344EF0", Offset = "0x83440F0", VA = "0x188344EF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x83456A0", Offset = "0x83448A0", VA = "0x1883456A0")]
		public DKMIOIRRDNM Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8345360", Offset = "0x8344560", VA = "0x188345360")]
		private static void RVPZTWDMBMK(DKMIOIRRDNM a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8345350", Offset = "0x8344550", VA = "0x188345350", Slot = "9")]
		public void RVPZTWDMBMK(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8345750", Offset = "0x8344950", VA = "0x188345750")]
		public static DKMIOIRRDNM TGEHZHMPRZZ(DKMIOIRRDNM a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface LWPIQZSFGRO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool VYPEKZIVOSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> NHOQXSPRIJD;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<HJIMNRPSBJR> CMHOQUNWHDX;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MPSAKZMSCGK(LegacyConnectableManager a, DZCPLFMACGO b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XDFQKTJZJHP(FAIXARNZTHF a, FAIXARNZTHF b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YSHUKJFUDNB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KJUPOPKRAEC(ConnectableGraphData a, [Optional] HJIMNRPSBJR b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class AXRVFSFNFAC
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8344550", Offset = "0x8343750", VA = "0x188344550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x83444C0", Offset = "0x83436C0", VA = "0x1883444C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8344500", Offset = "0x8343700", VA = "0x188344500")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class RWWVTHYDXPT : LWPIQZSFGRO, IDisposable, IURFPAEZSNY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager JIYKLYRLQAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DZCPLFMACGO DTVCIXWKVCS;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool VYPEKZIVOSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8353D30", Offset = "0x8352F30", VA = "0x188353D30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8353F40", Offset = "0x8353140", VA = "0x188353F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView LAYDACTLOPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8353F80", Offset = "0x8353180", VA = "0x188353F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> NHOQXSPRIJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8354770", Offset = "0x8353970", VA = "0x188354770", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8353C50", Offset = "0x8352E50", VA = "0x188353C50", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<HJIMNRPSBJR> CMHOQUNWHDX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x83549C0", Offset = "0x8353BC0", VA = "0x1883549C0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8354800", Offset = "0x8353A00", VA = "0x188354800", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8353EB0", Offset = "0x83530B0", VA = "0x188353EB0", Slot = "10")]
		public void MPSAKZMSCGK(LegacyConnectableManager a, DZCPLFMACGO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8353CE0", Offset = "0x8352EE0", VA = "0x188353CE0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x83548A0", Offset = "0x8353AA0", VA = "0x1883548A0", Slot = "11")]
		public void XDFQKTJZJHP(FAIXARNZTHF a, FAIXARNZTHF b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8354A60", Offset = "0x8353C60", VA = "0x188354A60", Slot = "12")]
		public void YSHUKJFUDNB(FAIXARNZTHF a, int b, FAIXARNZTHF c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8353D90", Offset = "0x8352F90", VA = "0x188353D90", Slot = "13")]
		public void KJUPOPKRAEC(ConnectableGraphData a, [Optional] HJIMNRPSBJR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8354250", Offset = "0x8353450", VA = "0x188354250")]
		[RPCMethod]
		private void RpcMasterReparentNodes(FAIXARNZTHF objectToReparent, int objectToReparentSlotIndex, FAIXARNZTHF newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8354060", Offset = "0x8353260", VA = "0x188354060")]
		[RPCMethod]
		private void RpcMasterModifyNode(FAIXARNZTHF connectableToModify, FAIXARNZTHF expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8354640", Offset = "0x8353840", VA = "0x188354640")]
		[RPCMethod]
		private void RpcReparentNodes(FAIXARNZTHF objectToReparent, int objectToReparentSlotIndex, FAIXARNZTHF newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8354550", Offset = "0x8353750", VA = "0x188354550")]
		[RPCMethod]
		private void RpcModifyNode(FAIXARNZTHF connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8354020", Offset = "0x8353220", VA = "0x188354020")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RWWVTHYDXPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, ZCLHXELWHEC, OTQATCHPJIK.PTNTGEMJGXK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x83469A0", Offset = "0x8345BA0", VA = "0x1883469A0", Slot = "4")]
		private void ZZSUAMNGMGV(FAIXARNZTHF a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x83464F0", Offset = "0x83456F0", VA = "0x1883464F0", Slot = "5")]
		private void MGUPIABSZYR(FAIXARNZTHF a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8346250", Offset = "0x8345450", VA = "0x188346250", Slot = "6")]
		private void CUZIRGTJVUS(FAIXARNZTHF a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8346750", Offset = "0x8345950", VA = "0x188346750", Slot = "7")]
		private void SOEMYHJSEOS(FAIXARNZTHF a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8346480", Offset = "0x8345680", VA = "0x188346480", Slot = "8")]
		private ZCLHXELWHEC KEXJQWLSKCB(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8346940", Offset = "0x8345B40", VA = "0x188346940", Slot = "9")]
		private void VUHJPYCMHET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class UCHPLUANFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9830", Offset = "0x3BF8A30", VA = "0x183BF9830")]
		public static OKCEEBBIMTZ<a> DTBKSFVWFFA<a>(this CYZVJPHMMVM a)
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
