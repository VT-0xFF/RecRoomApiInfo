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
		[Cpp2IlInjected.Address(RVA = "0x890ABA0", Offset = "0x89097A0", VA = "0x18890ABA0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] XIIVHNVBZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset MVJKAKABJST;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x269CC00", Offset = "0x269B800", VA = "0x18269CC00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x891A310", Offset = "0x8918F10", VA = "0x18891A310")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x891A460", Offset = "0x8919060", VA = "0x18891A460")]
		private void SHDRDVSMHNB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x891A000", Offset = "0x8918C00", VA = "0x18891A000", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x891A5B0", Offset = "0x89191B0", VA = "0x18891A5B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : VEKTRRNQVPT, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class EQBRRJLPZVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public FKUZEIZXSIO LOVNCKYPURX;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EQBRRJLPZVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8901E90", Offset = "0x8900A90", VA = "0x188901E90")]
			internal object OOPSQWDQATG(FKUZEIZXSIO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JPGOKMFXYHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int IIZTUWOYVKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int ZRJZXPNZQNA;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public JPGOKMFXYHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8902720", Offset = "0x8901320", VA = "0x188902720")]
			internal object MRRJJIAKCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IYYKLORVOJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OMConnectableManager VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public ZJWUIFZIEUJ JGTZMIFPONL;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IYYKLORVOJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x89026B0", Offset = "0x89012B0", VA = "0x1889026B0")]
			internal object ZGTQCJDFSXE(ZJWUIFZIEUJ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class IYTDOHXYEXW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ZJWUIFZIEUJ EFMODQRZQTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IYYKLORVOJF JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IYTDOHXYEXW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8902460", Offset = "0x8901060", VA = "0x188902460")]
			internal object ZGYWZPXDCIN((ZJWUIFZIEUJ child, ZJWUIFZIEUJ nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BYXCNGYXQKQ : IEnumerable<FKUZEIZXSIO>, IEnumerable, IEnumerator<FKUZEIZXSIO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private FKUZEIZXSIO DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private ObjectLocalId SEURIKANHTT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public ObjectLocalId RJTETMIXXQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public OMConnectableManager VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private DKLSIYTFFDM MKOMBFFFTHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private NativeObjectLocalIdArray QAQIEBOLARO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private NativeObjectLocalIdArray.Enumerator OKCJTLDNCCX;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private FKUZEIZXSIO KVASGPNKGHW
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public BYXCNGYXQKQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8901170", Offset = "0x88FFD70", VA = "0x188901170", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8900D90", Offset = "0x88FF990", VA = "0x188900D90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8901110", Offset = "0x88FFD10", VA = "0x188901110")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x89010F0", Offset = "0x88FFCF0", VA = "0x1889010F0")]
			private void QCRABUYCHCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8901130", Offset = "0x88FFD30", VA = "0x188901130", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8900CE0", Offset = "0x88FF8E0", VA = "0x188900CE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FKUZEIZXSIO> DQBXWZOTOET()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8900CE0", Offset = "0x88FF8E0", VA = "0x188900CE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log WIUZGBKVRCI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log CTFQPOIFKIK;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log MTJWNCTBKQW;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log TTODNNIOXGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VKSDSUMMTNH SKTTMHOWGQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MJMHTPKULHI GRZMMZHEFQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private YXXLGTLFZOL VMCZVEOWHIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private YLMQFGZUUKD CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ENFZMKMMJPN WTXIWFALRCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EUWQNGQQJND TCOYGPUMDRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly BDOPQIINDDA QAHOXJHWHNX;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB13150", Offset = "0xB11D50", VA = "0x180B13150", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB13260", Offset = "0xB11E60", VA = "0x180B13260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PCRWIYOCHQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO> MLQSLKCWQUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x89124D0", Offset = "0x89110D0", VA = "0x1889124D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x890F7A0", Offset = "0x890E3A0", VA = "0x18890F7A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO> AKDLFEAAZIT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x890D4F0", Offset = "0x890C0F0", VA = "0x18890D4F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8911EA0", Offset = "0x8910AA0", VA = "0x188911EA0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO, FKUZEIZXSIO> WVRUYFOGEAV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x890FEF0", Offset = "0x890EAF0", VA = "0x18890FEF0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8912F70", Offset = "0x8911B70", VA = "0x188912F70", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8913810", Offset = "0x8912410", VA = "0x188913810")]
		public OMConnectableManager(DiContainer container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x890EDB0", Offset = "0x890D9B0", VA = "0x18890EDB0", Slot = "12")]
		public void Initialize(GameObject gameObject, YZKULBEHOQQ configData, YOSQWXSZDJZ sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8911CD0", Offset = "0x89108D0", VA = "0x188911CD0", Slot = "26")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89105A0", Offset = "0x890F1A0", VA = "0x1889105A0", Slot = "22")]
		public bool QCPVBGKJXXT(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x890E830", Offset = "0x890D430", VA = "0x18890E830")]
		private void FJOUZTPPASO(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8912AA0", Offset = "0x89116A0", VA = "0x188912AA0")]
		private void VLGCWLEOGAE(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8910AC0", Offset = "0x890F6C0", VA = "0x188910AC0")]
		private void QGBPRRIQPMS(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x890F020", Offset = "0x890DC20", VA = "0x18890F020")]
		private void JTOMFHCOVUV(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x890E160", Offset = "0x890CD60", VA = "0x18890E160", Slot = "14")]
		public void ERBMWTZFFKA(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x890D990", Offset = "0x890C590", VA = "0x18890D990", Slot = "15")]
		public void BUEMJHJNWRJ(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8910840", Offset = "0x890F440", VA = "0x188910840", Slot = "17")]
		public void QFKLJJONMMK(FKUZEIZXSIO a, FKUZEIZXSIO b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89105F0", Offset = "0x890F1F0", VA = "0x1889105F0")]
		public void QFKLJJONMMK(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8910E50", Offset = "0x890FA50", VA = "0x188910E50")]
		public void RMTRPMVSQXU(FKUZEIZXSIO a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x890DAF0", Offset = "0x890C6F0", VA = "0x18890DAF0", Slot = "18")]
		public void BUONQHVIBHM(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x890D8E0", Offset = "0x890C4E0", VA = "0x18890D8E0")]
		private float AVOXLFMDYHA(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x890DFB0", Offset = "0x890CBB0", VA = "0x18890DFB0")]
		public void BUONQHVIBHM(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8912690", Offset = "0x8911290", VA = "0x188912690", Slot = "19")]
		public void VILKSJURRVS(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x890EBA0", Offset = "0x890D7A0", VA = "0x18890EBA0", Slot = "16")]
		public void GRELNRZODHO(FKUZEIZXSIO a, HashSet<FKUZEIZXSIO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "20")]
		public ConnectableGraphData GGSKABEZFUZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "21")]
		public ConnectableGraphData GHJPCWCMUPR(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x890E0F0", Offset = "0x890CCF0", VA = "0x18890E0F0", Slot = "23")]
		public void DWPHAWCFGPA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8913490", Offset = "0x8912090", VA = "0x188913490", Slot = "24")]
		public void ZCOSHQCDPJC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8913500", Offset = "0x8912100", VA = "0x188913500", Slot = "25")]
		public void ZSTZJQJIZYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x890FFA0", Offset = "0x890EBA0", VA = "0x18890FFA0")]
		private void PGJKPCAOGMM(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8911220", Offset = "0x890FE20", VA = "0x188911220")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8910530", Offset = "0x890F130", VA = "0x188910530")]
		private void QCNFYWCRSHB(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x890FD10", Offset = "0x890E910", VA = "0x18890FD10")]
		[IteratorStateMachine(typeof(BYXCNGYXQKQ))]
		public IEnumerable<FKUZEIZXSIO> MTBWFOTCKKQ(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x890FBE0", Offset = "0x890E7E0", VA = "0x18890FBE0")]
		internal FKUZEIZXSIO LYCFTHZPCST(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8912DE0", Offset = "0x89119E0", VA = "0x188912DE0")]
		internal ObjectLocalId VYQAJVHFQWH(FKUZEIZXSIO a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8911F50", Offset = "0x8910B50", VA = "0x188911F50")]
		private bool UCSNAWSYTBQ(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x890FE90", Offset = "0x890EA90", VA = "0x18890FE90")]
		private bool NWIKXENSFDQ(ZJWUIFZIEUJ a, [Out] FKUZEIZXSIO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x890F850", Offset = "0x890E450", VA = "0x18890F850")]
		private FKUZEIZXSIO LYCFTHZPCST(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8913520", Offset = "0x8912120", VA = "0x188913520")]
		private FKUZEIZXSIO ZYPWDZSRODS(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x890E660", Offset = "0x890D260", VA = "0x18890E660")]
		private FKUZEIZXSIO EZPSGJTHVHP(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x890B860", Offset = "0x890A460", VA = "0x18890B860")]
		private static Guid FVEYVUHJYSW(ZJWUIFZIEUJ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x890FDA0", Offset = "0x890E9A0", VA = "0x18890FDA0")]
		private string NLIUXEEVJFN(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x890F460", Offset = "0x890E060", VA = "0x18890F460")]
		private void LNYZEUOUOUQ(FKUZEIZXSIO a, FKUZEIZXSIO b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x890D5A0", Offset = "0x890C1A0", VA = "0x18890D5A0")]
		private void ALXRJTJMEMA(FKUZEIZXSIO a, FKUZEIZXSIO b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89132A0", Offset = "0x8911EA0", VA = "0x1889132A0")]
		private void WPSPZFUXKVM(FKUZEIZXSIO a, FKUZEIZXSIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8910EE0", Offset = "0x890FAE0", VA = "0x188910EE0")]
		private void RSLHABHXIBJ(FKUZEIZXSIO a, FKUZEIZXSIO b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8912580", Offset = "0x8911180", VA = "0x188912580")]
		private void UNJHWELDTWS(ObjectLocalId a, FKUZEIZXSIO b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8913020", Offset = "0x8911C20", VA = "0x188913020")]
		private void WOSWWQTQPPX(ObjectLocalId a, FKUZEIZXSIO b, FKUZEIZXSIO c, FKUZEIZXSIO d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class GCXSSWTNKJC
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public DiContainer container;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8919900", Offset = "0x8918500", VA = "0x188919900")]
			internal OMConnectableManager ZQZLKJYKQFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8902110", Offset = "0x8900D10", VA = "0x188902110")]
		public static void DHZFGJIYBFM(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8902280", Offset = "0x8900E80", VA = "0x188902280")]
		public static void DTJAMQNZLSZ(DiContainer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class OMConnectableToolImpl : GFHQDUXCBDE, ORLIDMNESHF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly RigidbodyEx MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly OMConnectableManager ACVKHQTSEVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly CPSPCDECJYE OMARPEGYBDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DOSYKBDOWXS CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly YOATGCGPXLI[] QZBSVYBNJDY;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FKUZEIZXSIO ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8915580", Offset = "0x8914180", VA = "0x188915580", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FKUZEIZXSIO HVVCSCYBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8914F20", Offset = "0x8913B20", VA = "0x188914F20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 YXAKMKJRFNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8913950", Offset = "0x8912550", VA = "0x188913950", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion HDHVCDPDLJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8913E70", Offset = "0x8912A70", VA = "0x188913E70", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BPLOQLSWRPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8913AF0", Offset = "0x89126F0", VA = "0x188913AF0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<FKUZEIZXSIO> VNYYKANTAPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8914120", Offset = "0x8912D20", VA = "0x188914120", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool FGVMSTPNESN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xDE26E0", Offset = "0xDE12E0", VA = "0x180DE26E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xEF2BF0", Offset = "0xEF17F0", VA = "0x180EF2BF0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8915780", Offset = "0x8914380", VA = "0x188915780", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x89154A0", Offset = "0x89140A0", VA = "0x1889154A0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x89154C0", Offset = "0x89140C0", VA = "0x1889154C0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x89155E0", Offset = "0x89141E0", VA = "0x1889155E0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x89156C0", Offset = "0x89142C0", VA = "0x1889156C0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool OCPENFIYVDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8914600", Offset = "0x8913200", VA = "0x188914600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler REXZQRTRGRN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8915270", Offset = "0x8913E70", VA = "0x188915270", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8913A00", Offset = "0x8912600", VA = "0x188913A00", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler IIBUKMYQUTD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8913ED0", Offset = "0x8912AD0", VA = "0x188913ED0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8914150", Offset = "0x8912D50", VA = "0x188914150", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler UMVSLPEBBCC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8915220", Offset = "0x8913E20", VA = "0x188915220", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x89139B0", Offset = "0x89125B0", VA = "0x1889139B0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler ZYKCVCNSKFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8914650", Offset = "0x8913250", VA = "0x188914650", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8913880", Offset = "0x8912480", VA = "0x188913880", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89153A0", Offset = "0x8913FA0", VA = "0x1889153A0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, CPSPCDECJYE connectableTool, YOATGCGPXLI[] connectionPoints, DOSYKBDOWXS callbacks, VEKTRRNQVPT connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8913920", Offset = "0x8912520", VA = "0x188913920", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "21")]
		public void LDKTOHQSZQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89150A0", Offset = "0x8913CA0", VA = "0x1889150A0", Slot = "22")]
		public void TWXJBPHXNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8915050", Offset = "0x8913C50", VA = "0x188915050", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8914770", Offset = "0x8913370", VA = "0x188914770", Slot = "25")]
		public void MSHTZBDTVMJ(int a, FKUZEIZXSIO b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8914B70", Offset = "0x8913770", VA = "0x188914B70", Slot = "26")]
		public void NDBTVBIYZIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8914C40", Offset = "0x8913840", VA = "0x188914C40", Slot = "27")]
		public void QHWNVFFSYXF(int a, FKUZEIZXSIO b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89146F0", Offset = "0x89132F0", VA = "0x1889146F0", Slot = "28")]
		public void MMIGANDPQAF(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89141F0", Offset = "0x8912DF0", VA = "0x1889141F0", Slot = "31")]
		public void ISPGZHMONGG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8913B60", Offset = "0x8912760", VA = "0x188913B60", Slot = "29")]
		public void DVFAHBEMVAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8914980", Offset = "0x8913580", VA = "0x188914980", Slot = "30")]
		public void MVRVDWONQAD(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8914050", Offset = "0x8912C50", VA = "0x188914050", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8913F20", Offset = "0x8912B20", VA = "0x188913F20", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB98650", Offset = "0xB97250", VA = "0x180B98650", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8913A50", Offset = "0x8912650", VA = "0x188913A50", Slot = "43")]
		public bool CanConnectTo(int slotIndex, FKUZEIZXSIO otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "44")]
		public void ParentChanged(int slotIndex, FKUZEIZXSIO newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "45")]
		public void ChildAdded(int slotIndex, FKUZEIZXSIO newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "46")]
		public void ChildRemoved(int slotIndex, FKUZEIZXSIO removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "47")]
		public void ConnectionModified(int slotIndex, FKUZEIZXSIO parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8914FE0", Offset = "0x8913BE0", VA = "0x188914FE0", Slot = "48")]
		public void RootChanged(FKUZEIZXSIO previousRootConnectable, FKUZEIZXSIO newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8915000", Offset = "0x8913C00", VA = "0x188915000", Slot = "23")]
		public void SAXMOIKIIHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89152C0", Offset = "0x8913EC0", VA = "0x1889152C0", Slot = "24")]
		public void XVDGRFCRVDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89141A0", Offset = "0x8912DA0", VA = "0x1889141A0")]
		private void IFKNCMWHBAG(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(PSFFSXTPRNR), new string[] { })]
	public class NMVVXSVFFFS : PSFFSXTPRNR, GAEEWOIWDJG, OBETOEUHEYQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[DependsOn]
		private TFADQQRDWCX PONDLUKDZAU;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object QOJUXTJRXWB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x890D3A0", Offset = "0x890BFA0", VA = "0x18890D3A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x890D430", Offset = "0x890C030", VA = "0x18890D430", Slot = "5")]
		private void HGJHKCHSQDI(BVNDYEZSFBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x13F4D60", Offset = "0x13F3960", VA = "0x1813F4D60", Slot = "6")]
		private void PBSAMQJMUVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public NMVVXSVFFFS()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(VEKTRRNQVPT), new string[] { "Ignore", "Mock" })]
	public class YAKEIBXVZDQ : VEKTRRNQVPT, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool PCRWIYOCHQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO> MLQSLKCWQUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8919EA0", Offset = "0x8918AA0", VA = "0x188919EA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8919C90", Offset = "0x8918890", VA = "0x188919C90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO> AKDLFEAAZIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8919BE0", Offset = "0x89187E0", VA = "0x188919BE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8919DF0", Offset = "0x89189F0", VA = "0x188919DF0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO, FKUZEIZXSIO> WVRUYFOGEAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8919D40", Offset = "0x8918940", VA = "0x188919D40", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8919F50", Offset = "0x8918B50", VA = "0x188919F50", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "26")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		public void Initialize(GameObject gameObject, YZKULBEHOQQ configData, YOSQWXSZDJZ rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "14")]
		public void ERBMWTZFFKA(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "15")]
		public void BUEMJHJNWRJ(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "16")]
		public void GRELNRZODHO(FKUZEIZXSIO a, HashSet<FKUZEIZXSIO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "17")]
		public void QFKLJJONMMK(FKUZEIZXSIO a, FKUZEIZXSIO b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "18")]
		public void BUONQHVIBHM(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "19")]
		public void VILKSJURRVS(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "20")]
		public ConnectableGraphData GGSKABEZFUZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "21")]
		public ConnectableGraphData GHJPCWCMUPR(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "22")]
		public bool QCPVBGKJXXT(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "23")]
		public void DWPHAWCFGPA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "24")]
		public void ZCOSHQCDPJC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "25")]
		public void ZSTZJQJIZYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public YAKEIBXVZDQ()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface FKUZEIZXSIO : ORLIDMNESHF, IEquatable<FKUZEIZXSIO>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ORLIDMNESHF
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		FKUZEIZXSIO ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Vector3 GetConnectionSlotLocalPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Vector3 GetConnectionSlotPosition(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Color GetConnectionSlotColor(int slotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool CanConnectTo(int slotIndex, FKUZEIZXSIO otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, FKUZEIZXSIO newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, FKUZEIZXSIO newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, FKUZEIZXSIO removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, FKUZEIZXSIO parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(FKUZEIZXSIO previousRootConnectable, FKUZEIZXSIO newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VEKTRRNQVPT : BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool PCRWIYOCHQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<FKUZEIZXSIO, FKUZEIZXSIO> MLQSLKCWQUZ;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<FKUZEIZXSIO, FKUZEIZXSIO> AKDLFEAAZIT;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<FKUZEIZXSIO, FKUZEIZXSIO, FKUZEIZXSIO> WVRUYFOGEAV;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, YZKULBEHOQQ configData, YOSQWXSZDJZ rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ERBMWTZFFKA(FKUZEIZXSIO a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BUEMJHJNWRJ(FKUZEIZXSIO a);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GRELNRZODHO(FKUZEIZXSIO a, HashSet<FKUZEIZXSIO> b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void QFKLJJONMMK(FKUZEIZXSIO a, FKUZEIZXSIO b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void BUONQHVIBHM(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void VILKSJURRVS(FKUZEIZXSIO a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData GGSKABEZFUZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData GHJPCWCMUPR(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool QCPVBGKJXXT(ZJWUIFZIEUJ a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void DWPHAWCFGPA(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ZCOSHQCDPJC(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ZSTZJQJIZYZ(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface YLMQFGZUUKD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FKUZEIZXSIO EZPSGJTHVHP(int a);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FKUZEIZXSIO ZYPWDZSRODS(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LREHLUTEZDO(FKUZEIZXSIO a);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RSDNCHMSZXO();

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FFQHCAIYZJJ(FKUZEIZXSIO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DOSYKBDOWXS
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OCPENFIYVDG(CPSPCDECJYE a);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZXSOZUCWMPD(CPSPCDECJYE a);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string WSLXOGUNDTC(CPSPCDECJYE a);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid QDVNAWOVMKL(CPSPCDECJYE a);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int LETADHNPFEU(CPSPCDECJYE a);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YWFUTHJPTPJ(CPSPCDECJYE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void HierarchyChangeHandler(FKUZEIZXSIO childConnectable, int childConnectableSlot, FKUZEIZXSIO parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void RootChangeHandler(FKUZEIZXSIO previousRootConnectable, FKUZEIZXSIO newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface CPSPCDECJYE : FKUZEIZXSIO, ORLIDMNESHF, IEquatable<FKUZEIZXSIO>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface GFHQDUXCBDE : ORLIDMNESHF
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		FKUZEIZXSIO HVVCSCYBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<FKUZEIZXSIO> VNYYKANTAPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 YXAKMKJRFNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion HDHVCDPDLJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool BPLOQLSWRPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool FGVMSTPNESN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler REXZQRTRGRN;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler IIBUKMYQUTD;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler UMVSLPEBBCC;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler ZYKCVCNSKFP;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void LDKTOHQSZQL();

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void TWXJBPHXNLC();

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void SAXMOIKIIHT();

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void XVDGRFCRVDA();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void MSHTZBDTVMJ(int a, FKUZEIZXSIO b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void NDBTVBIYZIZ();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void QHWNVFFSYXF(int a, FKUZEIZXSIO b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void MMIGANDPQAF(FKUZEIZXSIO a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void DVFAHBEMVAQ();

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void MVRVDWONQAD(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void ISPGZHMONGG(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface YOATGCGPXLI
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 ZHZOHCKEBFD
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface YZKULBEHOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool OIJHDKEQQSC
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		YTIWAQSTZIX WHEUSBDNAAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ConnectableConfigData : ScriptableObject, YZKULBEHOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool OIJHDKEQQSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public YTIWAQSTZIX WHEUSBDNAAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8901640", Offset = "0x8900240", VA = "0x188901640")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8901700", Offset = "0x8900300", VA = "0x188901700")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FKUZEIZXSIO connectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int parentSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8901BC0", Offset = "0x89007C0", VA = "0x188901BC0")]
		public ConnectableLink(FKUZEIZXSIO connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8901C20", Offset = "0x8900820", VA = "0x188901C20")]
		public ConnectableLink(FKUZEIZXSIO connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8901CC0", Offset = "0x89008C0", VA = "0x188901CC0")]
		public ConnectableLink(FKUZEIZXSIO connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8901750", Offset = "0x8900350", VA = "0x188901750", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8901800", Offset = "0x8900400", VA = "0x188901800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : CUUTCHQICOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Transform CVWZDLYBYWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private YTIWAQSTZIX JUUFTMWUVEX;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82A83D0", Offset = "0x82A6FD0", VA = "0x1882A83D0", Slot = "4")]
		public void Initialize(Transform transform, YTIWAQSTZIX linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8902840", Offset = "0x8901440", VA = "0x188902840", Slot = "5")]
		public YTIWAQSTZIX NBLNRCNZZFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8902900", Offset = "0x8901500", VA = "0x188902900", Slot = "6")]
		public void ZWEGNKKDBGR(YTIWAQSTZIX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal class LegacyConnectableManagerGraph : IDisposable, RCSDGHXSMNH
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class FTNYYFHXZBU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public FKUZEIZXSIO TIYSFFNMPVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public FKUZEIZXSIO MYRNYDPUOSB;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public FTNYYFHXZBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8902050", Offset = "0x8900C50", VA = "0x188902050")]
			internal bool MKCSPCASPFZ(XRFQMSCVGEC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly ORVAIHZHPQT TGVZOLEYXNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private AJALIJHIJGO WSUGYIRSLQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private VBBHNDQLVYS DITQFZNGCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool JSKJDFODZCG;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Log RRBIYMMGWOQ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public XRFQMSCVGEC DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8905450", Offset = "0x8904050", VA = "0x188905450")]
		public bool UBHZFYWFIXI([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x89069F0", Offset = "0x89055F0", VA = "0x1889069F0")]
		private bool XFUQTOCUEQR([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8907CA0", Offset = "0x89068A0", VA = "0x188907CA0")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8904A90", Offset = "0x8903690", VA = "0x188904A90", Slot = "5")]
		public void Initialize(VEKTRRNQVPT manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8905550", Offset = "0x8904150", VA = "0x188905550", Slot = "17")]
		public void SRFJOEPUODR(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8907A70", Offset = "0x8906670", VA = "0x188907A70", Slot = "12")]
		public void ZXTRBLVKTRM(Func<FKUZEIZXSIO, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8907A80", Offset = "0x8906680", VA = "0x188907A80")]
		private void ZXTRBLVKTRM(ORVAIHZHPQT a, Func<FKUZEIZXSIO, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8907000", Offset = "0x8905C00", VA = "0x188907000", Slot = "11")]
		public void XKWCAUYLYZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8906FB0", Offset = "0x8905BB0", VA = "0x188906FB0", Slot = "8")]
		public bool XGPUFMGGEKH(FKUZEIZXSIO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8905C00", Offset = "0x8904800", VA = "0x188905C00")]
		private bool UGHYDLZACLW(FKUZEIZXSIO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x89054A0", Offset = "0x89040A0", VA = "0x1889054A0")]
		private static bool RYJJESUUKDY(FKUZEIZXSIO a, ORVAIHZHPQT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8903460", Offset = "0x8902060", VA = "0x188903460")]
		private void AXESEAUYHKM(Transform a, ORVAIHZHPQT b, ORVAIHZHPQT[] c, FKUZEIZXSIO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x89063A0", Offset = "0x8904FA0", VA = "0x1889063A0")]
		private ConnectableLink WEFGKLGJPEJ(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x89032A0", Offset = "0x8901EA0", VA = "0x1889032A0")]
		private static bool AOPVHMHZDWA(ORVAIHZHPQT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8906920", Offset = "0x8905520", VA = "0x188906920")]
		private string WSLXOGUNDTC(FKUZEIZXSIO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8904D90", Offset = "0x8903990", VA = "0x188904D90")]
		private string LETADHNPFEU(FKUZEIZXSIO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8903ED0", Offset = "0x8902AD0", VA = "0x188903ED0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FBNKRUJPFYJ([In] ConnectionOperationData data, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8904F20", Offset = "0x8903B20", VA = "0x188904F20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LZYWNCEDUTB(FKUZEIZXSIO a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8905650", Offset = "0x8904250", VA = "0x188905650")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void UENNWUQMJAI(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x89074B0", Offset = "0x89060B0", VA = "0x1889074B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void YHLLKMMUCHB(FKUZEIZXSIO a, int b, int c, Vector3 d, Quaternion e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8903DF0", Offset = "0x89029F0", VA = "0x188903DF0", Slot = "9")]
		public bool CLSLFBTKMZJ(FKUZEIZXSIO a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8907020", Offset = "0x8905C20", VA = "0x188907020")]
		private bool XLIBAZSCKWM(FKUZEIZXSIO a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8904B40", Offset = "0x8903740", VA = "0x188904B40")]
		private static void JVVNDKGAVTZ(FKUZEIZXSIO a, int b, int c, Vector3 d, Quaternion e, ORVAIHZHPQT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8904E00", Offset = "0x8903A00", VA = "0x188904E00")]
		private void LNYZEUOUOUQ(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x89052B0", Offset = "0x8903EB0", VA = "0x1889052B0")]
		private void PDNGSEZTPRW(ORVAIHZHPQT a, FKUZEIZXSIO b, FKUZEIZXSIO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8905240", Offset = "0x8903E40", VA = "0x188905240")]
		private void PDNGSEZTPRW(FKUZEIZXSIO a, FKUZEIZXSIO b, FKUZEIZXSIO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8906750", Offset = "0x8905350", VA = "0x188906750")]
		private void WOSWWQTQPPX(FKUZEIZXSIO a, FKUZEIZXSIO b, FKUZEIZXSIO c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8906650", Offset = "0x8905250", VA = "0x188906650")]
		private void WOSWWQTQPPX(ORVAIHZHPQT a, FKUZEIZXSIO b, FKUZEIZXSIO c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8903180", Offset = "0x8901D80", VA = "0x188903180")]
		private void ALXRJTJMEMA(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x89067C0", Offset = "0x89053C0", VA = "0x1889067C0")]
		private void WPSPZFUXKVM(XRFQMSCVGEC a, XRFQMSCVGEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x89064F0", Offset = "0x89050F0", VA = "0x1889064F0", Slot = "18")]
		public FKUZEIZXSIO WIZQOOJDLOL(FKUZEIZXSIO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x89044B0", Offset = "0x89030B0", VA = "0x1889044B0", Slot = "13")]
		public void GRELNRZODHO(FKUZEIZXSIO a, HashSet<FKUZEIZXSIO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8907270", Offset = "0x8905E70", VA = "0x188907270", Slot = "14")]
		public List<FKUZEIZXSIO> XNWWTFLECDW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8905580", Offset = "0x8904180", VA = "0x188905580")]
		protected XRFQMSCVGEC TEWYPTVIQCX(XRFQMSCVGEC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8906300", Offset = "0x8904F00", VA = "0x188906300")]
		protected ORVAIHZHPQT[] UWPCWPFAWIU(ORVAIHZHPQT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8904980", Offset = "0x8903580", VA = "0x188904980")]
		protected bool HSXQDFNVENH(FKUZEIZXSIO a, [Out] ORVAIHZHPQT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8905320", Offset = "0x8903F20", VA = "0x188905320", Slot = "15")]
		public bool QVPXEBGNDER(FKUZEIZXSIO a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8904850", Offset = "0x8903450", VA = "0x188904850")]
		protected ORVAIHZHPQT HEKCEPDYFLE(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8904890", Offset = "0x8903490", VA = "0x188904890", Slot = "10")]
		public bool HHIUMRDRMTX(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8903850", Offset = "0x8902450", VA = "0x188903850")]
		private bool CDQXGZHGOBW(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8904CC0", Offset = "0x89038C0", VA = "0x188904CC0")]
		private static bool KGIYHGIFOLI(ORVAIHZHPQT a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8905450", Offset = "0x8904050", VA = "0x188905450", Slot = "7")]
		private bool RTPOSDZOMYX([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : VEKTRRNQVPT, BMZVOVVGZNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		internal readonly DiContainer container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		internal readonly VBBHNDQLVYS DITQFZNGCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly CJEOCGBYYST VGGIEBGAQHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly NEXDAKEUHYJ ZQUSNIXEDRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		internal readonly RCSDGHXSMNH SFVPIRVKJAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		internal CDKMHDUBMDE CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		internal FMGAFUBZVHT BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal AJALIJHIJGO LTDYYEZXZJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal bool JSKJDFODZCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private bool PFFUJRACJNJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LOYYOUVXKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xB60720", Offset = "0xB5F320", VA = "0x180B60720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xB603D0", Offset = "0xB5EFD0", VA = "0x180B603D0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D20", Offset = "0xBB2920", VA = "0x180BB3D20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D10", Offset = "0xBB2910", VA = "0x180BB3D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PCRWIYOCHQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO> MLQSLKCWQUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x89096F0", Offset = "0x89082F0", VA = "0x1889096F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x89090C0", Offset = "0x8907CC0", VA = "0x1889090C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO> AKDLFEAAZIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8907E50", Offset = "0x8906A50", VA = "0x188907E50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8909690", Offset = "0x8908290", VA = "0x188909690", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<FKUZEIZXSIO, FKUZEIZXSIO, FKUZEIZXSIO> WVRUYFOGEAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8909300", Offset = "0x8907F00", VA = "0x188909300", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8909990", Offset = "0x8908590", VA = "0x188909990", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8909AE0", Offset = "0x89086E0", VA = "0x188909AE0")]
		public LegacyConnectableManager(DiContainer container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x89089C0", Offset = "0x89075C0", VA = "0x1889089C0", Slot = "12")]
		public void Initialize(GameObject gameObject, YZKULBEHOQQ configData, YOSQWXSZDJZ rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x89095C0", Offset = "0x89081C0", VA = "0x1889095C0", Slot = "26")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8909750", Offset = "0x8908350", VA = "0x188909750", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8908440", Offset = "0x8907040", VA = "0x188908440", Slot = "14")]
		public void ERBMWTZFFKA(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8907EB0", Offset = "0x8906AB0", VA = "0x188907EB0", Slot = "15")]
		public void BUEMJHJNWRJ(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8909360", Offset = "0x8907F60", VA = "0x188909360", Slot = "22")]
		public bool QCPVBGKJXXT(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8908050", Offset = "0x8906C50", VA = "0x188908050")]
		internal bool CDQXGZHGOBW([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8908870", Offset = "0x8907470", VA = "0x188908870")]
		internal bool IERUJWBGPKO([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8909120", Offset = "0x8907D20", VA = "0x188909120")]
		internal void MKVWQZFHMWO(FKUZEIZXSIO a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8907EB0", Offset = "0x8906AB0", VA = "0x188907EB0")]
		internal bool JXYBXQEJAOY(FKUZEIZXSIO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8908F80", Offset = "0x8907B80", VA = "0x188908F80")]
		internal bool JFFWXGKPUAK(FKUZEIZXSIO a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8908780", Offset = "0x8907380", VA = "0x188908780", Slot = "16")]
		public void GRELNRZODHO(FKUZEIZXSIO a, HashSet<FKUZEIZXSIO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x89093B0", Offset = "0x8907FB0", VA = "0x1889093B0", Slot = "17")]
		public void QFKLJJONMMK(FKUZEIZXSIO a, FKUZEIZXSIO b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8907F10", Offset = "0x8906B10", VA = "0x188907F10", Slot = "18")]
		public void BUONQHVIBHM(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x89097D0", Offset = "0x89083D0", VA = "0x1889097D0", Slot = "19")]
		public void VILKSJURRVS(FKUZEIZXSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8908160", Offset = "0x8906D60", VA = "0x188908160")]
		public void CIDXXDKRMTP([Optional] WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x89083B0", Offset = "0x8906FB0", VA = "0x1889083B0", Slot = "23")]
		public void DWPHAWCFGPA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8908460", Offset = "0x8907060", VA = "0x188908460", Slot = "20")]
		public ConnectableGraphData GGSKABEZFUZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x89085E0", Offset = "0x89071E0", VA = "0x1889085E0", Slot = "21")]
		public ConnectableGraphData GHJPCWCMUPR(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8909AA0", Offset = "0x89086A0", VA = "0x188909AA0", Slot = "25")]
		public void ZSTZJQJIZYZ(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89099F0", Offset = "0x89085F0", VA = "0x1889099F0", Slot = "24")]
		public void ZCOSHQCDPJC(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class VBBHNDQLVYS : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly HWISWPMUOCT<FKUZEIZXSIO, FKUZEIZXSIO> MLQSLKCWQUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly HWISWPMUOCT<FKUZEIZXSIO, FKUZEIZXSIO> AKDLFEAAZIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly HWDLZISXERK<FKUZEIZXSIO, FKUZEIZXSIO, FKUZEIZXSIO> WVRUYFOGEAV;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8919AE0", Offset = "0x89186E0", VA = "0x188919AE0")]
		public VBBHNDQLVYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8919A80", Offset = "0x8918680", VA = "0x188919A80")]
		public void RFBGCUDVEYV(FKUZEIZXSIO a, FKUZEIZXSIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8919A20", Offset = "0x8918620", VA = "0x188919A20")]
		public void HRYZQLDONWT(FKUZEIZXSIO a, FKUZEIZXSIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x89199A0", Offset = "0x89185A0", VA = "0x1889199A0")]
		public void FKOEOEICCGF(FKUZEIZXSIO a, FKUZEIZXSIO b, FKUZEIZXSIO c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class CJEOCGBYYST : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private LegacyConnectableManager ZHYWUYYWQFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private FMGAFUBZVHT BRMMXAVOEUT;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CJEOCGBYYST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8901260", Offset = "0x88FFE60", VA = "0x188901260")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8901250", Offset = "0x88FFE50", VA = "0x188901250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8901500", Offset = "0x8900100", VA = "0x188901500")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8901490", Offset = "0x8900090", VA = "0x188901490")]
		private void OnMasterClientSwitched(WJBKOLNRRJE newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8901390", Offset = "0x88FFF90", VA = "0x188901390")]
		public void KFOBHDDOHTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8901540", Offset = "0x8900140", VA = "0x188901540")]
		public void STLXYOKPTTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class AMOHLIUOPZB
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public DiContainer container;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x89198A0", Offset = "0x89184A0", VA = "0x1889198A0")]
			internal LegacyConnectableManager ZQZLKJYKQFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8900A70", Offset = "0x88FF670", VA = "0x188900A70")]
		public static void DHZFGJIYBFM(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8900C60", Offset = "0x88FF860", VA = "0x188900C60")]
		public static void DTJAMQNZLSZ(DiContainer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, AJALIJHIJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Dictionary<int, YTIWAQSTZIX> WJCKUUOQXWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly ConnectableHierarchyTraversalOperation XJNKQLPWOYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CUUTCHQICOF UYJHJLCVWST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private RCSDGHXSMNH SFVPIRVKJAT;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static ProfilerMarker SEHWIDCODRX;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x890AAD0", Offset = "0x89096D0", VA = "0x18890AAD0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x890A310", Offset = "0x8908F10", VA = "0x18890A310", Slot = "7")]
		public void Initialize(RCSDGHXSMNH graph, CUUTCHQICOF creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x890A350", Offset = "0x8908F50", VA = "0x18890A350", Slot = "5")]
		public void MSDJJZZNGPE(XRFQMSCVGEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x890A590", Offset = "0x8909190", VA = "0x18890A590", Slot = "9")]
		public void MWJWUETNKVH(XRFQMSCVGEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x890A700", Offset = "0x8909300", VA = "0x18890A700", Slot = "8")]
		public void NJYXDORWVPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8909FC0", Offset = "0x8908BC0", VA = "0x188909FC0", Slot = "10")]
		public void ISLFUTHCZJM(XRFQMSCVGEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8909E70", Offset = "0x8908A70", VA = "0x188909E70", Slot = "11")]
		public void BXJQHPPGDZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x890A8C0", Offset = "0x89094C0", VA = "0x18890A8C0")]
		private bool ZILAWHFACHP(XRFQMSCVGEC a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class NEXDAKEUHYJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private readonly ORVAIHZHPQT currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private readonly ZJWUIFZIEUJ parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private readonly ZJWUIFZIEUJ rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool IKPBXPVZSDI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x8917A50", Offset = "0x8916650", VA = "0x188917A50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8917F80", Offset = "0x8916B80", VA = "0x188917F80")]
			public SerializeNodeInSubgraph(ORVAIHZHPQT currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] ZJWUIFZIEUJ parentNodeData, [Optional] ZJWUIFZIEUJ rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8917B60", Offset = "0x8916760", VA = "0x188917B60")]
			public ZJWUIFZIEUJ Serialize()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8917D00", Offset = "0x8916900", VA = "0x188917D00")]
			private ZJWUIFZIEUJ TORRUJRITEV([Out] ZJWUIFZIEUJ a, [Out] ZJWUIFZIEUJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8917850", Offset = "0x8916450", VA = "0x188917850")]
			private ZJWUIFZIEUJ ESKDTTXGLQD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x89176E0", Offset = "0x89162E0", VA = "0x1889176E0")]
			private void BQGLVUAFRGB(ZJWUIFZIEUJ a, ZJWUIFZIEUJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8917DC0", Offset = "0x89169C0", VA = "0x188917DC0")]
			private void XGKNSKJFKUW(ZJWUIFZIEUJ a, ZJWUIFZIEUJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private LegacyConnectableManager ZHYWUYYWQFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private RCSDGHXSMNH SFVPIRVKJAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private AJALIJHIJGO WSUGYIRSLQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private FMGAFUBZVHT BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool OOUASQOZRSJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool ULGOBOZGTWW
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x890AD30", Offset = "0x8909930", VA = "0x18890AD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool LOYYOUVXKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1BCC6E0", Offset = "0x1BCB2E0", VA = "0x181BCC6E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x890AEA0", Offset = "0x8909AA0", VA = "0x18890AEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x890BBB0", Offset = "0x890A7B0", VA = "0x18890BBB0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x890B8A0", Offset = "0x890A4A0", VA = "0x18890B8A0")]
		public ConnectableGraphData GGSKABEZFUZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x890BA10", Offset = "0x890A610", VA = "0x18890BA10")]
		public ConnectableGraphData GHJPCWCMUPR(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x890B200", Offset = "0x8909E00", VA = "0x18890B200")]
		public void DWPHAWCFGPA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x890D290", Offset = "0x890BE90", VA = "0x18890D290")]
		public void ZCOSHQCDPJC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x890C5F0", Offset = "0x890B1F0", VA = "0x18890C5F0")]
		public void PHKGMWJZVVE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x890C620", Offset = "0x890B220", VA = "0x18890C620")]
		private void PWDTXGQXSEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x890C1A0", Offset = "0x890ADA0", VA = "0x18890C1A0")]
		private ZJWUIFZIEUJ MZFYDSWCTJX(ORVAIHZHPQT a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x890AEC0", Offset = "0x8909AC0", VA = "0x18890AEC0")]
		private static void CCZJGHEJXQF(ORVAIHZHPQT a, bool b, ZJWUIFZIEUJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x890BC20", Offset = "0x890A820", VA = "0x18890BC20")]
		private void KGRULQCGLFQ(ORVAIHZHPQT a, bool b, ZJWUIFZIEUJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x890B170", Offset = "0x8909D70", VA = "0x18890B170")]
		private ZJWUIFZIEUJ DMHBZHZBJED(ORVAIHZHPQT a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x890C370", Offset = "0x890AF70", VA = "0x18890C370")]
		private bool ORQGQWDZLMH(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x890CA90", Offset = "0x890B690", VA = "0x18890CA90")]
		private bool UCSNAWSYTBQ(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x890BE40", Offset = "0x890AA40", VA = "0x18890BE40")]
		private bool LQCCQPRNJVO(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x890AD80", Offset = "0x8909980", VA = "0x18890AD80")]
		private static bool AYCXREAFTEJ(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x890C800", Offset = "0x890B400", VA = "0x18890C800")]
		public static bool QCPVBGKJXXT(ZJWUIFZIEUJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x890BE60", Offset = "0x890AA60", VA = "0x18890BE60")]
		private FKUZEIZXSIO LYCFTHZPCST(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x890B290", Offset = "0x8909E90", VA = "0x18890B290")]
		private FKUZEIZXSIO EZPSGJTHVHP(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x890D100", Offset = "0x890BD00", VA = "0x18890D100")]
		private FKUZEIZXSIO YBZXPAQHTTC(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x890B860", Offset = "0x890A460", VA = "0x18890B860")]
		private static Guid FVEYVUHJYSW(ZJWUIFZIEUJ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x890C280", Offset = "0x890AE80", VA = "0x18890C280")]
		private string NLIUXEEVJFN(ZJWUIFZIEUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x890B410", Offset = "0x890A010", VA = "0x18890B410")]
		private bool FDXJHKQFGZE(ORVAIHZHPQT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x890B600", Offset = "0x890A200", VA = "0x18890B600")]
		private static void FUPPKNBBRAQ(ORVAIHZHPQT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public NEXDAKEUHYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FKUZEIZXSIO child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FKUZEIZXSIO parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int childSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int parentSlotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Vector3 relativePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Quaternion relativeRotation;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ConnectableLink UDYDNJAWTZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8901D80", Offset = "0x8900980", VA = "0x188901D80")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink SECCZVCRABP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8901D50", Offset = "0x8900950", VA = "0x188901D50")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8901E20", Offset = "0x8900A20", VA = "0x188901E20")]
		public ConnectionOperationData(FKUZEIZXSIO child, FKUZEIZXSIO parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface RCSDGHXSMNH
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		XRFQMSCVGEC DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(VEKTRRNQVPT manager);

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UBHZFYWFIXI([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool XGPUFMGGEKH(FKUZEIZXSIO a);

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CLSLFBTKMZJ(FKUZEIZXSIO a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HHIUMRDRMTX(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XKWCAUYLYZE();

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ZXTRBLVKTRM(Func<FKUZEIZXSIO, bool> a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GRELNRZODHO(FKUZEIZXSIO a, HashSet<FKUZEIZXSIO> b);

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<FKUZEIZXSIO> XNWWTFLECDW();

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool QVPXEBGNDER(FKUZEIZXSIO a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void SRFJOEPUODR(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal delegate bool ConnectableHierarchyTraversalOperation(XRFQMSCVGEC node);
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal interface XRFQMSCVGEC
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		FKUZEIZXSIO KSZYTLXYEON
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		XRFQMSCVGEC MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink SFNVNDPQTKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool YOWTATEGXCF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface YTIWAQSTZIX
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HRTIXRMSTIX(FKUZEIZXSIO a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KXGSNXFCXDV(FKUZEIZXSIO a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MCSJHBREZTK(FKUZEIZXSIO a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TTJQHNDFAOE(FKUZEIZXSIO a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YTIWAQSTZIX HQOOLPPEGBJ(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface CUUTCHQICOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, YTIWAQSTZIX linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YTIWAQSTZIX NBLNRCNZZFD();

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZWEGNKKDBGR(YTIWAQSTZIX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface CDKMHDUBMDE : YLMQFGZUUKD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ICSTLMUGAEM();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PKLNOCAPHYJ(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface AJALIJHIJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MSDJJZZNGPE(XRFQMSCVGEC a);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(RCSDGHXSMNH graph, CUUTCHQICOF linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NJYXDORWVPJ();

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MWJWUETNKVH(XRFQMSCVGEC a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ISLFUTHCZJM(XRFQMSCVGEC a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BXJQHPPGDZU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class ORVAIHZHPQT : XRFQMSCVGEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class PPNWEOHNLEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public ConnectableLink NMQYZOIDJMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public ORVAIHZHPQT QMPATVUZDYL;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PPNWEOHNLEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8916650", Offset = "0x8915250", VA = "0x188916650")]
			internal bool TMRHMWYARNY(XRFQMSCVGEC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private ConnectableLink DXUFHSVXADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LinkedList<ORVAIHZHPQT> GWCWITBPEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private ORVAIHZHPQT OMMMMYQCGSS;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink SFNVNDPQTKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x160A870", Offset = "0x1609470", VA = "0x18160A870", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x160A9D0", Offset = "0x16095D0", VA = "0x18160A9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ORVAIHZHPQT GUMKFVWGXHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8915D20", Offset = "0x8914920", VA = "0x188915D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public XRFQMSCVGEC MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public FKUZEIZXSIO KSZYTLXYEON
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool YOWTATEGXCF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8915CA0", Offset = "0x89148A0", VA = "0x188915CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NZUQKYYXWNT
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8915CB0", Offset = "0x89148B0", VA = "0x188915CB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ORVAIHZHPQT PPGZRRIGXVH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8915D00", Offset = "0x8914900", VA = "0x188915D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x89164C0", Offset = "0x89150C0", VA = "0x1889164C0")]
		public ORVAIHZHPQT(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8915A70", Offset = "0x8914670", VA = "0x188915A70")]
		public ORVAIHZHPQT DOINHEJLOPM(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x89157A0", Offset = "0x89143A0", VA = "0x1889157A0")]
		public ORVAIHZHPQT CHIVCRPQYDA(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8915E00", Offset = "0x8914A00", VA = "0x188915E00")]
		public ORVAIHZHPQT Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8915920", Offset = "0x8914520", VA = "0x188915920")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8915FE0", Offset = "0x8914BE0", VA = "0x188915FE0")]
		public ORVAIHZHPQT Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x89160A0", Offset = "0x8914CA0", VA = "0x1889160A0")]
		private static void SRFJOEPUODR(ORVAIHZHPQT a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8916090", Offset = "0x8914C90", VA = "0x188916090", Slot = "9")]
		public void SRFJOEPUODR(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8916200", Offset = "0x8914E00", VA = "0x188916200")]
		public static string ToString(ORVAIHZHPQT traversalRoot, int depth = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8915BB0", Offset = "0x89147B0", VA = "0x188915BB0")]
		public static ORVAIHZHPQT HEKCEPDYFLE(ORVAIHZHPQT a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal interface FMGAFUBZVHT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool ULGOBOZGTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> LTFSCMJSPUG;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<WJBKOLNRRJE> GXYINHYWKGE;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HRTIXRMSTIX(LegacyConnectableManager a, YOSQWXSZDJZ b);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void QFKLJJONMMK(FKUZEIZXSIO a, FKUZEIZXSIO b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BUONQHVIBHM(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GKJEINFNOTZ(ConnectableGraphData a, [Optional] WJBKOLNRRJE b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class PBIYRJIFROR
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x8916600", Offset = "0x8915200", VA = "0x188916600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x89165C0", Offset = "0x89151C0", VA = "0x1889165C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8916560", Offset = "0x8915160", VA = "0x188916560")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class QKCJNSFXLOG : FMGAFUBZVHT, IDisposable, MPSKMBLLYLT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private LegacyConnectableManager ZHYWUYYWQFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private YOSQWXSZDJZ UPJKJBQXFNZ;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ULGOBOZGTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8916790", Offset = "0x8915390", VA = "0x188916790", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x8916A00", Offset = "0x8915600", VA = "0x188916A00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView EPCVQWBCLSF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x89175A0", Offset = "0x89161A0", VA = "0x1889175A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> LTFSCMJSPUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x8916960", Offset = "0x8915560", VA = "0x188916960", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x8917500", Offset = "0x8916100", VA = "0x188917500", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<WJBKOLNRRJE> GXYINHYWKGE
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x8917640", Offset = "0x8916240", VA = "0x188917640", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x8916BF0", Offset = "0x89157F0", VA = "0x188916BF0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8916B60", Offset = "0x8915760", VA = "0x188916B60", Slot = "10")]
		public void HRTIXRMSTIX(LegacyConnectableManager a, YOSQWXSZDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8916910", Offset = "0x8915510", VA = "0x188916910", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8916C90", Offset = "0x8915890", VA = "0x188916C90", Slot = "11")]
		public void QFKLJJONMMK(FKUZEIZXSIO a, FKUZEIZXSIO b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x89167F0", Offset = "0x89153F0", VA = "0x1889167F0", Slot = "12")]
		public void BUONQHVIBHM(FKUZEIZXSIO a, int b, FKUZEIZXSIO c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8916A40", Offset = "0x8915640", VA = "0x188916A40", Slot = "13")]
		public void GKJEINFNOTZ(ConnectableGraphData a, [Optional] WJBKOLNRRJE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8916FE0", Offset = "0x8915BE0", VA = "0x188916FE0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(FKUZEIZXSIO objectToReparent, int objectToReparentSlotIndex, FKUZEIZXSIO newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8916DF0", Offset = "0x89159F0", VA = "0x188916DF0")]
		[RPCMethod]
		private void RpcMasterModifyNode(FKUZEIZXSIO connectableToModify, FKUZEIZXSIO expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x89173D0", Offset = "0x8915FD0", VA = "0x1889173D0")]
		[RPCMethod]
		private void RpcReparentNodes(FKUZEIZXSIO objectToReparent, int objectToReparentSlotIndex, FKUZEIZXSIO newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x89172E0", Offset = "0x8915EE0", VA = "0x1889172E0")]
		[RPCMethod]
		private void RpcModifyNode(FKUZEIZXSIO connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8916DB0", Offset = "0x89159B0", VA = "0x188916DB0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QKCJNSFXLOG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, YTIWAQSTZIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8902D30", Offset = "0x8901930", VA = "0x188902D30", Slot = "4")]
		private void QOVEDQELPAG(FKUZEIZXSIO a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8902EB0", Offset = "0x8901AB0", VA = "0x188902EB0", Slot = "5")]
		private void XJZSFYWUKNI(FKUZEIZXSIO a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8902970", Offset = "0x8901570", VA = "0x188902970", Slot = "6")]
		private void FTGYLCAOAAH(FKUZEIZXSIO a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8902AD0", Offset = "0x89016D0", VA = "0x188902AD0", Slot = "7")]
		private void GGWPVGYZIVD(FKUZEIZXSIO a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8902CC0", Offset = "0x89018C0", VA = "0x188902CC0", Slot = "8")]
		private YTIWAQSTZIX ISHAAGLMQQY(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8903120", Offset = "0x8901D20", VA = "0x188903120", Slot = "9")]
		private void ZUWMSEWXDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class WEZQXRPZRWL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x41A35D0", Offset = "0x41A21D0", VA = "0x1841A35D0")]
		public static PCLZTNTBCAI<a> IMPBQDATGVF<a>(this DiContainer a)
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
