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
		[Cpp2IlInjected.Address(RVA = "0x81A2260", Offset = "0x81A1660", VA = "0x1881A2260", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		private int[] DTCBHPALRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] DTHIEVUJATD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GTGGRGPIZNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GTAZTZVLQCO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC810", Offset = "0x1EBBC10", VA = "0x181EBC810", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81ADF00", Offset = "0x81AD300", VA = "0x1881ADF00")]
		private void RGTQLMDRHIR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81ADDB0", Offset = "0x81AD1B0", VA = "0x1881ADDB0")]
		private void RGOJOFJTXXI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81AE050", Offset = "0x81AD450", VA = "0x1881AE050", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81AE360", Offset = "0x81AD760", VA = "0x1881AE360")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : MVKCOMEZCMQ, LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JYUQISDLSPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public YGKOEWMSPXW EOXZTXOAMFI;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public JYUQISDLSPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x819B3F0", Offset = "0x819A7F0", VA = "0x18819B3F0")]
			internal object GSTCEYQQVBT(YGKOEWMSPXW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JYZXFYXJCAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public YGKOEWMSPXW TPAYUSXYLZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JYUQISDLSPM AAFJFKGKTGT;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public JYZXFYXJCAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x819B460", Offset = "0x819A860", VA = "0x18819B460")]
			internal object GSNVHRWTLQK((YGKOEWMSPXW child, YGKOEWMSPXW nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JUBNUWIXLJP : IEnumerable<QLJARVWWUTL>, IEnumerable, IEnumerator<QLJARVWWUTL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private QLJARVWWUTL JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId JLYWRSYRKJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId NUVSASHLKRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private LNGQTCAXYFX RIXLUXAWFXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray KBGIPICWCOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator BPCLGXRRVQM;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private QLJARVWWUTL PGAWMERBWZV
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public JUBNUWIXLJP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x819AE80", Offset = "0x819A280", VA = "0x18819AE80", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x819B050", Offset = "0x819A450", VA = "0x18819B050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x819B3B0", Offset = "0x819A7B0", VA = "0x18819B3B0")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x819B3D0", Offset = "0x819A7D0", VA = "0x18819B3D0")]
			private void RZEKLAKLXKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x819B010", Offset = "0x819A410", VA = "0x18819B010", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x819AF60", Offset = "0x819A360", VA = "0x18819AF60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<QLJARVWWUTL> GSSYFCMYDVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x819AF60", Offset = "0x819A360", VA = "0x18819AF60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log ZQOANWVLEVT;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log HIXRIRMVDUR;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log PSOKPJGPTGN;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log UPVMPLPDMKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PWUPVFQBAGE MDJJLWTMVIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GYGFXJBKLMH DTKCKNLSDVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private GFLRQANDFVQ FSRIDCZPVKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BHFBCXBUTFS GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MPMUIZRKMRK KARZLEOBGWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NYHEUDSDETG IQOVWRNYMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly XFAXRWZYYDX PPITAPLWWNI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EGNAKZZXDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F30", Offset = "0xAA9330", VA = "0x180AA9F30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAA040", Offset = "0xAA9440", VA = "0x180AAA040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RSGTSMXYVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL> QSXLWTRVPKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x81A3C60", Offset = "0x81A3060", VA = "0x1881A3C60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x81A29E0", Offset = "0x81A1DE0", VA = "0x1881A29E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL> JESUTPSVDXE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81A3D10", Offset = "0x81A3110", VA = "0x1881A3D10", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x81A5300", Offset = "0x81A4700", VA = "0x1881A5300", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL, QLJARVWWUTL> ZLZJXMAYQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x81A5250", Offset = "0x81A4650", VA = "0x1881A5250", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x81A51A0", Offset = "0x81A45A0", VA = "0x1881A51A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81A7180", Offset = "0x81A6580", VA = "0x1881A7180")]
		public OMConnectableManager(XRSJVGYQFTW container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81A3DC0", Offset = "0x81A31C0", VA = "0x1881A3DC0", Slot = "12")]
		public void Initialize(GameObject gameObject, XTIJSFGVGFR configData, ZWCDIWYLDPO sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81A53B0", Offset = "0x81A47B0", VA = "0x1881A53B0", Slot = "26")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81A6790", Offset = "0x81A5B90", VA = "0x1881A6790", Slot = "22")]
		public bool WBFJCHWWLIO(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81A47B0", Offset = "0x81A3BB0", VA = "0x1881A47B0")]
		private void NTNHFXAAKRZ(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81A4590", Offset = "0x81A3990", VA = "0x1881A4590")]
		private void NOXSICIUADH(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81A4B30", Offset = "0x81A3F30", VA = "0x1881A4B30")]
		private void POEHEPYLBLV(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81A4D90", Offset = "0x81A4190", VA = "0x1881A4D90")]
		private void PRLLHDRYBUI(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81A5580", Offset = "0x81A4980", VA = "0x1881A5580", Slot = "14")]
		public void SHWXSEAJSCT(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "15")]
		public void WUGNLHLOTAM(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81A3A90", Offset = "0x81A2E90", VA = "0x1881A3A90", Slot = "17")]
		public void GVBNOWABNID(QLJARVWWUTL a, QLJARVWWUTL b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81A3950", Offset = "0x81A2D50", VA = "0x1881A3950")]
		public void GVBNOWABNID(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81A67E0", Offset = "0x81A5BE0", VA = "0x1881A67E0")]
		public void WCOYCDRELUF(QLJARVWWUTL a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81A4090", Offset = "0x81A3490", VA = "0x1881A4090", Slot = "18")]
		public void KQMVPZAFFVT(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81A44E0", Offset = "0x81A38E0", VA = "0x1881A44E0")]
		private float LZDLPARCHMT(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81A41F0", Offset = "0x81A35F0", VA = "0x1881A41F0")]
		public void KQMVPZAFFVT(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81A49C0", Offset = "0x81A3DC0", VA = "0x1881A49C0", Slot = "19")]
		public void OPMOLTOTEHX(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81A3490", Offset = "0x81A2890", VA = "0x1881A3490", Slot = "16")]
		public void DMXZPCYPCLF(QLJARVWWUTL a, HashSet<QLJARVWWUTL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "20")]
		public ConnectableGraphData RDFMOQONVVW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "21")]
		public ConnectableGraphData ENSDJZXBAAA(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81A3BF0", Offset = "0x81A2FF0", VA = "0x1881A3BF0", Slot = "23")]
		public void HONTDRLTXJP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81A2C20", Offset = "0x81A2020", VA = "0x1881A2C20", Slot = "24")]
		public void CIDCVZZXLJL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81A4330", Offset = "0x81A3730", VA = "0x1881A4330", Slot = "25")]
		public void KUMYSYXOMOG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81A6350", Offset = "0x81A5750", VA = "0x1881A6350")]
		private void UGQOBZGMLBL(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81A5A10", Offset = "0x81A4E10", VA = "0x1881A5A10")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81A62E0", Offset = "0x81A56E0", VA = "0x1881A62E0")]
		private void TLUUKEQXOCW(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81A2950", Offset = "0x81A1D50", VA = "0x1881A2950")]
		[IteratorStateMachine(typeof(JUBNUWIXLJP))]
		public IEnumerable<QLJARVWWUTL> AXHJFFFKYPV(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81A6870", Offset = "0x81A5C70", VA = "0x1881A6870")]
		internal QLJARVWWUTL WHPXJCROTYE(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81A4350", Offset = "0x81A3750", VA = "0x1881A4350")]
		internal ObjectLocalId KVABRUWIHOM(QLJARVWWUTL a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81A2C90", Offset = "0x81A2090", VA = "0x1881A2C90")]
		private bool CXCMOOSVIAB(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81A28F0", Offset = "0x81A1CF0", VA = "0x1881A28F0")]
		private bool AWYAOYYIEIR(YGKOEWMSPXW a, [Out] QLJARVWWUTL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81A69A0", Offset = "0x81A5DA0", VA = "0x1881A69A0")]
		private QLJARVWWUTL WHPXJCROTYE(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81A6EB0", Offset = "0x81A62B0", VA = "0x1881A6EB0")]
		private QLJARVWWUTL XBPVRXNOSBD(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81A36A0", Offset = "0x81A2AA0", VA = "0x1881A36A0")]
		private QLJARVWWUTL EKHIWFFPZGK(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81A6750", Offset = "0x81A5B50", VA = "0x1881A6750")]
		private static Guid USMNAZAHRCP(YGKOEWMSPXW a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81A3860", Offset = "0x81A2C60", VA = "0x1881A3860")]
		private string GEPFHKQCXEK(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81A5880", Offset = "0x81A4C80", VA = "0x1881A5880")]
		private void SYNNAWYCOPL(QLJARVWWUTL a, QLJARVWWUTL b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81A6D20", Offset = "0x81A6120", VA = "0x1881A6D20")]
		private void WLVYXGAQLJR(QLJARVWWUTL a, QLJARVWWUTL b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81A4030", Offset = "0x81A3430", VA = "0x1881A4030")]
		private void JWGYMBJHNGZ(QLJARVWWUTL a, QLJARVWWUTL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81A2A90", Offset = "0x81A1E90", VA = "0x1881A2A90")]
		private void BPSKVEQHTYE(QLJARVWWUTL a, QLJARVWWUTL b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81A27E0", Offset = "0x81A1BE0", VA = "0x1881A27E0")]
		private void AEGOEKYOWFT(ObjectLocalId a, QLJARVWWUTL b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81A3210", Offset = "0x81A2610", VA = "0x1881A3210")]
		private void DJFKQCZQJLQ(ObjectLocalId a, QLJARVWWUTL b, QLJARVWWUTL c, QLJARVWWUTL d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class QCGDULAIYNR
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public XRSJVGYQFTW container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x819AB70", Offset = "0x8199F70", VA = "0x18819AB70")]
			internal OMConnectableManager HEHMEMRIZUZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81A9260", Offset = "0x81A8660", VA = "0x1881A9260")]
		public static void XYIBIZWVTXT(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81A9210", Offset = "0x81A8610", VA = "0x1881A9210")]
		public static void WOWFMYLRNBU(XRSJVGYQFTW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : PEUKUIXOMTP, VLORQOXCQKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager VTRXZZCJKET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly WYPPOKSSCLV HJFFKZFTEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly LGGEJOGADJP GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly EDIJLBESCAN[] GEJACQUXCXX;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public QLJARVWWUTL ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x81A8D80", Offset = "0x81A8180", VA = "0x1881A8D80", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public QLJARVWWUTL BMOWUGKZTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x81A8040", Offset = "0x81A7440", VA = "0x1881A8040", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 QHJWREUKNEU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81A8A70", Offset = "0x81A7E70", VA = "0x1881A8A70", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion JACTNBETIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x81A77F0", Offset = "0x81A6BF0", VA = "0x1881A77F0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KVPTQLVZDNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x81A7450", Offset = "0x81A6850", VA = "0x1881A7450", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<QLJARVWWUTL> QYVLMLWAIVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x81A7AE0", Offset = "0x81A6EE0", VA = "0x1881A7AE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool HSZUKFJGNZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB42090", Offset = "0xB41490", VA = "0x180B42090", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB82840", Offset = "0xB81C40", VA = "0x180B82840", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x81A8F80", Offset = "0x81A8380", VA = "0x1881A8F80", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x81A8CA0", Offset = "0x81A80A0", VA = "0x1881A8CA0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x81A8CC0", Offset = "0x81A80C0", VA = "0x1881A8CC0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x81A8DE0", Offset = "0x81A81E0", VA = "0x1881A8DE0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x81A8EC0", Offset = "0x81A82C0", VA = "0x1881A8EC0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool EBOYCAOBIFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x81A88C0", Offset = "0x81A7CC0", VA = "0x1881A88C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler FXAXKIRJRHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x81A7DB0", Offset = "0x81A71B0", VA = "0x1881A7DB0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x81A7A90", Offset = "0x81A6E90", VA = "0x1881A7A90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler VQCELHTXXWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x81A8AD0", Offset = "0x81A7ED0", VA = "0x1881A8AD0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x81A8910", Offset = "0x81A7D10", VA = "0x1881A8910", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler JEQGTKOVFWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x81A8A20", Offset = "0x81A7E20", VA = "0x1881A8A20", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x81A77A0", Offset = "0x81A6BA0", VA = "0x1881A77A0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler WVQAZCLCCRY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x81A8410", Offset = "0x81A7810", VA = "0x1881A8410", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x81A7B10", Offset = "0x81A6F10", VA = "0x1881A7B10", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x81A8BA0", Offset = "0x81A7FA0", VA = "0x1881A8BA0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, WYPPOKSSCLV connectableTool, EDIJLBESCAN[] connectionPoints, LGGEJOGADJP callbacks, MVKCOMEZCMQ connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x81A7420", Offset = "0x81A6820", VA = "0x1881A7420", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "21")]
		public void QHGABOTDVTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81A7400", Offset = "0x81A6800", VA = "0x1881A7400", Slot = "22")]
		public void AZLGBHPFBUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81A89D0", Offset = "0x81A7DD0", VA = "0x1881A89D0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81A71F0", Offset = "0x81A65F0", VA = "0x1881A71F0", Slot = "25")]
		public void ACMSGPJEVOI(int a, QLJARVWWUTL b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81A7970", Offset = "0x81A6D70", VA = "0x1881A7970", Slot = "26")]
		public void EWAADWZINAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81A74C0", Offset = "0x81A68C0", VA = "0x1881A74C0", Slot = "27")]
		public void CEHZDVAAOJM(int a, QLJARVWWUTL b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81A78F0", Offset = "0x81A6CF0", VA = "0x1881A78F0", Slot = "28")]
		public void ESJCPRRIZFW(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81A84B0", Offset = "0x81A78B0", VA = "0x1881A84B0", Slot = "31")]
		public void OVXHMJVDROV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81A8100", Offset = "0x81A7500", VA = "0x1881A8100", Slot = "29")]
		public void LJKUMADIUZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81A7E00", Offset = "0x81A7200", VA = "0x1881A7E00", Slot = "30")]
		public void IVVBTFQJVXC(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81A7CE0", Offset = "0x81A70E0", VA = "0x1881A7CE0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81A7BB0", Offset = "0x81A6FB0", VA = "0x1881A7BB0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCBC610", Offset = "0xCBBA10", VA = "0x180CBC610", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81A7850", Offset = "0x81A6C50", VA = "0x1881A7850", Slot = "43")]
		public bool CanConnectTo(int slotIndex, QLJARVWWUTL otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "44")]
		public void ParentChanged(int slotIndex, QLJARVWWUTL newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "45")]
		public void ChildAdded(int slotIndex, QLJARVWWUTL newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "46")]
		public void ChildRemoved(int slotIndex, QLJARVWWUTL removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "47")]
		public void ConnectionModified(int slotIndex, QLJARVWWUTL parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81A89B0", Offset = "0x81A7DB0", VA = "0x1881A89B0", Slot = "48")]
		public void RootChanged(QLJARVWWUTL previousRootConnectable, QLJARVWWUTL newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81A7FF0", Offset = "0x81A73F0", VA = "0x1881A7FF0", Slot = "23")]
		public void JORVKXTUOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81A8960", Offset = "0x81A7D60", VA = "0x1881A8960", Slot = "24")]
		public void RLPLIBRFLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81A7A40", Offset = "0x81A6E40", VA = "0x1881A7A40")]
		private void FEIOGEZSDQT(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(DZDRTWBPGRG), new string[] { })]
	public class TQLIQWREGIR : DZDRTWBPGRG, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OBPSGXVZRRC
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OBPSGXVZRRC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private JZARGVCAEZK AWBSSZSCGNB;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object JINIOFGWLPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x81AC740", Offset = "0x81ABB40", VA = "0x1881AC740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81AC6F0", Offset = "0x81ABAF0", VA = "0x1881AC6F0", Slot = "5")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC5AA40", Offset = "0xC59E40", VA = "0x180C5AA40", Slot = "6")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TQLIQWREGIR()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(MVKCOMEZCMQ), new string[] { "Ignore", "Mock" })]
	public class RFHVUPATNAN : MVKCOMEZCMQ, LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EGNAKZZXDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RSGTSMXYVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL> QSXLWTRVPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x81ABA70", Offset = "0x81AAE70", VA = "0x1881ABA70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x81AB9C0", Offset = "0x81AADC0", VA = "0x1881AB9C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL> JESUTPSVDXE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x81ABB20", Offset = "0x81AAF20", VA = "0x1881ABB20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x81ABD30", Offset = "0x81AB130", VA = "0x1881ABD30", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL, QLJARVWWUTL> ZLZJXMAYQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x81ABC80", Offset = "0x81AB080", VA = "0x1881ABC80", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x81ABBD0", Offset = "0x81AAFD0", VA = "0x1881ABBD0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "26")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "12")]
		public void Initialize(GameObject gameObject, XTIJSFGVGFR configData, ZWCDIWYLDPO rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "14")]
		public void SHWXSEAJSCT(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "15")]
		public void WUGNLHLOTAM(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "16")]
		public void DMXZPCYPCLF(QLJARVWWUTL a, HashSet<QLJARVWWUTL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "17")]
		public void GVBNOWABNID(QLJARVWWUTL a, QLJARVWWUTL b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "18")]
		public void KQMVPZAFFVT(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "19")]
		public void OPMOLTOTEHX(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "20")]
		public ConnectableGraphData RDFMOQONVVW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "21")]
		public ConnectableGraphData ENSDJZXBAAA(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "22")]
		public bool WBFJCHWWLIO(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "23")]
		public void HONTDRLTXJP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "24")]
		public void CIDCVZZXLJL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "25")]
		public void KUMYSYXOMOG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RFHVUPATNAN()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface QLJARVWWUTL : VLORQOXCQKA, IEquatable<QLJARVWWUTL>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface VLORQOXCQKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		QLJARVWWUTL ParentConnectable
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
		bool CanConnectTo(int slotIndex, QLJARVWWUTL otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, QLJARVWWUTL newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, QLJARVWWUTL newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, QLJARVWWUTL removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, QLJARVWWUTL parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(QLJARVWWUTL previousRootConnectable, QLJARVWWUTL newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MVKCOMEZCMQ : LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool EGNAKZZXDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool RSGTSMXYVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<QLJARVWWUTL, QLJARVWWUTL> QSXLWTRVPKA;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<QLJARVWWUTL, QLJARVWWUTL> JESUTPSVDXE;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<QLJARVWWUTL, QLJARVWWUTL, QLJARVWWUTL> ZLZJXMAYQCS;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, XTIJSFGVGFR configData, ZWCDIWYLDPO rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SHWXSEAJSCT(QLJARVWWUTL a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void WUGNLHLOTAM(QLJARVWWUTL a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void DMXZPCYPCLF(QLJARVWWUTL a, HashSet<QLJARVWWUTL> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void GVBNOWABNID(QLJARVWWUTL a, QLJARVWWUTL b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void KQMVPZAFFVT(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OPMOLTOTEHX(QLJARVWWUTL a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData RDFMOQONVVW(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData ENSDJZXBAAA(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool WBFJCHWWLIO(YGKOEWMSPXW a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void HONTDRLTXJP(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void CIDCVZZXLJL(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void KUMYSYXOMOG(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BHFBCXBUTFS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		QLJARVWWUTL EKHIWFFPZGK(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QLJARVWWUTL XBPVRXNOSBD(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CWAZIVRLVPD(QLJARVWWUTL a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool JLSRDZXZKLR();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XDBQDGEWJRO(QLJARVWWUTL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LGGEJOGADJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EBOYCAOBIFV(WYPPOKSSCLV a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AZLQSOZTCTU(WYPPOKSSCLV a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string TNFSUNSNLCJ(WYPPOKSSCLV a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid HLXSGAHNSTO(WYPPOKSSCLV a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int EPBAMMDSKBX(WYPPOKSSCLV a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ISCNMSKPPOQ(WYPPOKSSCLV a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(QLJARVWWUTL childConnectable, int childConnectableSlot, QLJARVWWUTL parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(QLJARVWWUTL previousRootConnectable, QLJARVWWUTL newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface WYPPOKSSCLV : QLJARVWWUTL, VLORQOXCQKA, IEquatable<QLJARVWWUTL>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PEUKUIXOMTP : VLORQOXCQKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		QLJARVWWUTL BMOWUGKZTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<QLJARVWWUTL> QYVLMLWAIVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 QHJWREUKNEU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion JACTNBETIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool KVPTQLVZDNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool HSZUKFJGNZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler FXAXKIRJRHA;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler VQCELHTXXWA;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler JEQGTKOVFWD;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler WVQAZCLCCRY;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void QHGABOTDVTS();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void AZLGBHPFBUN();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void JORVKXTUOKK();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void RLPLIBRFLKF();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ACMSGPJEVOI(int a, QLJARVWWUTL b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void EWAADWZINAE();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void CEHZDVAAOJM(int a, QLJARVWWUTL b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ESJCPRRIZFW(QLJARVWWUTL a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void LJKUMADIUZR();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void IVVBTFQJVXC(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void OVXHMJVDROV(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EDIJLBESCAN
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 KXOICWVHSUI
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
	public interface XTIJSFGVGFR
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool FXUUZQYWYXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		SUHNFWRICLC VURLXGMXVGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, XTIJSFGVGFR
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
		public bool FXUUZQYWYXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public SUHNFWRICLC VURLXGMXVGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81997B0", Offset = "0x8198BB0", VA = "0x1881997B0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8199870", Offset = "0x8198C70", VA = "0x188199870")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public QLJARVWWUTL connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x8199E40", Offset = "0x8199240", VA = "0x188199E40")]
		public ConnectableLink(QLJARVWWUTL connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8199DA0", Offset = "0x81991A0", VA = "0x188199DA0")]
		public ConnectableLink(QLJARVWWUTL connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8199D20", Offset = "0x8199120", VA = "0x188199D20")]
		public ConnectableLink(QLJARVWWUTL connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81998C0", Offset = "0x8198CC0", VA = "0x1881998C0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8199970", Offset = "0x8198D70", VA = "0x188199970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : BHCMVXNWZYE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform WJCWXTHIKWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private SUHNFWRICLC DKPFSBHMUII;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B18240", Offset = "0x7B17640", VA = "0x187B18240", Slot = "4")]
		public void Initialize(Transform transform, SUHNFWRICLC linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x819B710", Offset = "0x819AB10", VA = "0x18819B710", Slot = "5")]
		public SUHNFWRICLC NOYJKJWAXZA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x819B6A0", Offset = "0x819AAA0", VA = "0x18819B6A0", Slot = "6")]
		public void HDJPDEPVRZW(SUHNFWRICLC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, IHZIMMUZDMM
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ZDJLHJLETPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public QLJARVWWUTL RSTTYPEDKYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public QLJARVWWUTL IEVXISSCUFY;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZDJLHJLETPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x81ACDC0", Offset = "0x81AC1C0", VA = "0x1881ACDC0")]
			internal bool JSBBZHKLTSY(ADJOKRJYTUT a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly DETLCWEPBJK NIVJIAUBHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private ZBMUIWLAHQL DSXFMDIERBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private XFIRREWIGWN UGHAPRNKCGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool TLKVIYUASKB;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log SVDOUTDURJJ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ADJOKRJYTUT JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x819D480", Offset = "0x819C880", VA = "0x18819D480")]
		public bool HIZHJJYNGOV([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x819C5B0", Offset = "0x819B9B0", VA = "0x18819C5B0")]
		private bool CKZRKODHSLK([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x819F360", Offset = "0x819E760", VA = "0x18819F360")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x819D640", Offset = "0x819CA40", VA = "0x18819D640", Slot = "5")]
		public void Initialize(MVKCOMEZCMQ manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x819D610", Offset = "0x819CA10", VA = "0x18819D610", Slot = "17")]
		public void IZJEYNGMLJG(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x819C1B0", Offset = "0x819B5B0", VA = "0x18819C1B0", Slot = "12")]
		public void BXYNDVFGQWD(Func<QLJARVWWUTL, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x819C080", Offset = "0x819B480", VA = "0x18819C080")]
		private void BXYNDVFGQWD(DETLCWEPBJK a, Func<QLJARVWWUTL, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x819DFC0", Offset = "0x819D3C0", VA = "0x18819DFC0", Slot = "11")]
		public void OQJLETURXFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x819D850", Offset = "0x819CC50", VA = "0x18819D850", Slot = "8")]
		public bool KUACUPZGYVK(QLJARVWWUTL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x819E9B0", Offset = "0x819DDB0", VA = "0x18819E9B0")]
		private bool WGHMKNBUPFH(QLJARVWWUTL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x819BFD0", Offset = "0x819B3D0", VA = "0x18819BFD0")]
		private static bool AFIJERJEGEL(QLJARVWWUTL a, DETLCWEPBJK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x819C1C0", Offset = "0x819B5C0", VA = "0x18819C1C0")]
		private void CGTLDTASJRZ(Transform a, DETLCWEPBJK b, DETLCWEPBJK[] c, QLJARVWWUTL d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x819E4F0", Offset = "0x819D8F0", VA = "0x18819E4F0")]
		private ConnectableLink SSNKISCGSCO(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x819E220", Offset = "0x819D620", VA = "0x18819E220")]
		private static bool QFEKDUXJPKV(DETLCWEPBJK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x819D0A0", Offset = "0x819C4A0", VA = "0x18819D0A0", Slot = "9")]
		public bool EBWGASYSKUA(QLJARVWWUTL a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x819D100", Offset = "0x819C500", VA = "0x18819D100")]
		private bool GAWOEUVGYDH(QLJARVWWUTL a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x819E830", Offset = "0x819DC30", VA = "0x18819E830")]
		private static void VQDHVIJYVMM(QLJARVWWUTL a, int b, int c, Vector3 d, Quaternion e, DETLCWEPBJK f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x819E640", Offset = "0x819DA40", VA = "0x18819E640")]
		private void SYNNAWYCOPL(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x819D500", Offset = "0x819C900", VA = "0x18819D500")]
		private void HVIOUFUWMEB(DETLCWEPBJK a, QLJARVWWUTL b, QLJARVWWUTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x819D490", Offset = "0x819C890", VA = "0x18819D490")]
		private void HVIOUFUWMEB(QLJARVWWUTL a, QLJARVWWUTL b, QLJARVWWUTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x819CB60", Offset = "0x819BF60", VA = "0x18819CB60")]
		private void DJFKQCZQJLQ(QLJARVWWUTL a, QLJARVWWUTL b, QLJARVWWUTL c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x819CBD0", Offset = "0x819BFD0", VA = "0x18819CBD0")]
		private void DJFKQCZQJLQ(DETLCWEPBJK a, QLJARVWWUTL b, QLJARVWWUTL c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x819F0B0", Offset = "0x819E4B0", VA = "0x18819F0B0")]
		private void WLVYXGAQLJR(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x819D6F0", Offset = "0x819CAF0", VA = "0x18819D6F0")]
		private void JWGYMBJHNGZ(ADJOKRJYTUT a, ADJOKRJYTUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x819D860", Offset = "0x819CC60", VA = "0x18819D860", Slot = "18")]
		public QLJARVWWUTL MDXZTVIKUFS(QLJARVWWUTL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x819CCD0", Offset = "0x819C0D0", VA = "0x18819CCD0", Slot = "13")]
		public void DMXZPCYPCLF(QLJARVWWUTL a, HashSet<QLJARVWWUTL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x819DFE0", Offset = "0x819D3E0", VA = "0x18819DFE0", Slot = "14")]
		public List<QLJARVWWUTL> PGMZOGNFJIT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x819F1D0", Offset = "0x819E5D0", VA = "0x18819F1D0")]
		protected ADJOKRJYTUT YDAWIQDCDXO(ADJOKRJYTUT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x819D570", Offset = "0x819C970", VA = "0x18819D570")]
		protected DETLCWEPBJK[] IAJJIKILAGJ(DETLCWEPBJK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x819E3E0", Offset = "0x819D7E0", VA = "0x18819E3E0")]
		protected bool SQAVPXWASXK(QLJARVWWUTL a, [Out] DETLCWEPBJK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x819D350", Offset = "0x819C750", VA = "0x18819D350", Slot = "15")]
		public bool GXOKSVDROMU(QLJARVWWUTL a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x819D060", Offset = "0x819C460", VA = "0x18819D060")]
		protected DETLCWEPBJK DPYNFIVZQEB(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x819D9C0", Offset = "0x819CDC0", VA = "0x18819D9C0", Slot = "10")]
		public bool NQWPMUCYUMA(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x819DA20", Offset = "0x819CE20", VA = "0x18819DA20")]
		private bool NTMTHHIXCPF(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x819E760", Offset = "0x819DB60", VA = "0x18819E760")]
		private static bool TEMYYGGAGAN(DETLCWEPBJK a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x819D480", Offset = "0x819C880", VA = "0x18819D480", Slot = "7")]
		private bool YPBYZHRGWPS([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : MVKCOMEZCMQ, LGPJMXYAVLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly XRSJVGYQFTW container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly XFIRREWIGWN UGHAPRNKCGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly NBOFWLTVQXM TPLWMSCDKYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly QEELOLOAZMQ JIDPYILYDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly IHZIMMUZDMM LKCBOZYZZFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal QKECDIBEATX GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal QSVUMOHNGYG UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal ZBMUIWLAHQL RNWWNSZAVOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool TLKVIYUASKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool CLAJFOWJCJU;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DPSZRRXBKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAEFBF0", Offset = "0xAEEFF0", VA = "0x180AEFBF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAEF7B0", Offset = "0xAEEBB0", VA = "0x180AEF7B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EGNAKZZXDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1020F90", Offset = "0x1020390", VA = "0x181020F90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x24B4F50", Offset = "0x24B4350", VA = "0x1824B4F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool RSGTSMXYVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL> QSXLWTRVPKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x819FC90", Offset = "0x819F090", VA = "0x18819FC90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x819F510", Offset = "0x819E910", VA = "0x18819F510", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL> JESUTPSVDXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x819FCF0", Offset = "0x819F0F0", VA = "0x18819FCF0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x81A0D40", Offset = "0x81A0140", VA = "0x1881A0D40", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<QLJARVWWUTL, QLJARVWWUTL, QLJARVWWUTL> ZLZJXMAYQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x81A0CE0", Offset = "0x81A00E0", VA = "0x1881A0CE0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x81A0B00", Offset = "0x819FF00", VA = "0x1881A0B00", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x81A11A0", Offset = "0x81A05A0", VA = "0x1881A11A0")]
		public LegacyConnectableManager(XRSJVGYQFTW container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x819FD50", Offset = "0x819F150", VA = "0x18819FD50", Slot = "12")]
		public void Initialize(GameObject gameObject, XTIJSFGVGFR configData, ZWCDIWYLDPO rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x81A0DA0", Offset = "0x81A01A0", VA = "0x1881A0DA0", Slot = "26")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81A0E90", Offset = "0x81A0290", VA = "0x1881A0E90", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x81A0E70", Offset = "0x81A0270", VA = "0x1881A0E70", Slot = "14")]
		public void SHWXSEAJSCT(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x81A0F10", Offset = "0x81A0310", VA = "0x1881A0F10", Slot = "15")]
		public void WUGNLHLOTAM(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x81A0F70", Offset = "0x81A0370", VA = "0x1881A0F70", Slot = "22")]
		public bool WBFJCHWWLIO(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x81A0830", Offset = "0x819FC30", VA = "0x1881A0830")]
		internal bool NTMTHHIXCPF([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x81A0310", Offset = "0x819F710", VA = "0x1881A0310")]
		internal bool JHYKCSYHIAF([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x81A0FC0", Offset = "0x81A03C0", VA = "0x1881A0FC0")]
		internal void WIGVEKPQKHT(QLJARVWWUTL a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x81A0F10", Offset = "0x81A0310", VA = "0x1881A0F10")]
		internal bool VVJHYUFFRPD(QLJARVWWUTL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x819F570", Offset = "0x819E970", VA = "0x18819F570")]
		internal bool CHSDMFBUIXN(QLJARVWWUTL a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x819F760", Offset = "0x819EB60", VA = "0x18819F760", Slot = "16")]
		public void DMXZPCYPCLF(QLJARVWWUTL a, HashSet<QLJARVWWUTL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x819F9F0", Offset = "0x819EDF0", VA = "0x18819F9F0", Slot = "17")]
		public void GVBNOWABNID(QLJARVWWUTL a, QLJARVWWUTL b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x81A06B0", Offset = "0x819FAB0", VA = "0x1881A06B0", Slot = "18")]
		public void KQMVPZAFFVT(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x81A0940", Offset = "0x819FD40", VA = "0x1881A0940", Slot = "19")]
		public void OPMOLTOTEHX(QLJARVWWUTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x81A0460", Offset = "0x819F860", VA = "0x1881A0460")]
		public void KFWTLBOEVSE([Optional] JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x819FC00", Offset = "0x819F000", VA = "0x18819FC00", Slot = "23")]
		public void HONTDRLTXJP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x81A0B60", Offset = "0x819FF60", VA = "0x1881A0B60", Slot = "20")]
		public ConnectableGraphData RDFMOQONVVW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x819F850", Offset = "0x819EC50", VA = "0x18819F850", Slot = "21")]
		public ConnectableGraphData ENSDJZXBAAA(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x81A07F0", Offset = "0x819FBF0", VA = "0x1881A07F0", Slot = "25")]
		public void KUMYSYXOMOG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x819F6B0", Offset = "0x819EAB0", VA = "0x18819F6B0", Slot = "24")]
		public void CIDCVZZXLJL(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class XFIRREWIGWN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly KBQWMGAGJLQ<QLJARVWWUTL, QLJARVWWUTL> QSXLWTRVPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly KBQWMGAGJLQ<QLJARVWWUTL, QLJARVWWUTL> JESUTPSVDXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly KBWDJMUDSWZ<QLJARVWWUTL, QLJARVWWUTL, QLJARVWWUTL> ZLZJXMAYQCS;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x81ACB80", Offset = "0x81ABF80", VA = "0x1881ACB80")]
		public XFIRREWIGWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x81ACAA0", Offset = "0x81ABEA0", VA = "0x1881ACAA0")]
		public void KCFVGLNUBMI(QLJARVWWUTL a, QLJARVWWUTL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x81ACA40", Offset = "0x81ABE40", VA = "0x1881ACA40")]
		public void FMVJCWIUQBQ(QLJARVWWUTL a, QLJARVWWUTL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x81ACB00", Offset = "0x81ABF00", VA = "0x1881ACB00")]
		public void OHDLYJCASGG(QLJARVWWUTL a, QLJARVWWUTL b, QLJARVWWUTL c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class NBOFWLTVQXM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager KYSGMPHMQKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private QSVUMOHNGYG UGOVYLDDXNG;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NBOFWLTVQXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x81A2500", Offset = "0x81A1900", VA = "0x1881A2500")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x81A23F0", Offset = "0x81A17F0", VA = "0x1881A23F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x81A26A0", Offset = "0x81A1AA0", VA = "0x1881A26A0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x81A2630", Offset = "0x81A1A30", VA = "0x1881A2630")]
		private void OnMasterClientSwitched(JCSDFORPEFX newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x81A26E0", Offset = "0x81A1AE0", VA = "0x1881A26E0")]
		public void VGSJPJIZNCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x81A2400", Offset = "0x81A1800", VA = "0x1881A2400")]
		public void FHCZRMQODCV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class PCRARBITOGU
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public XRSJVGYQFTW container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x819AB10", Offset = "0x8199F10", VA = "0x18819AB10")]
			internal LegacyConnectableManager HEHMEMRIZUZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x81A9020", Offset = "0x81A8420", VA = "0x1881A9020")]
		public static void XYIBIZWVTXT(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x81A8FA0", Offset = "0x81A83A0", VA = "0x1881A8FA0")]
		public static void WOWFMYLRNBU(XRSJVGYQFTW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, ZBMUIWLAHQL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, SUHNFWRICLC> TBIFBOJDFFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation IHMETMFKMVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private BHCMVXNWZYE NTFUGALBDDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private IHZIMMUZDMM LKCBOZYZZFY;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker BFBHPAWDYGM;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x81A2190", Offset = "0x81A1590", VA = "0x1881A2190")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x81A19B0", Offset = "0x81A0DB0", VA = "0x1881A19B0", Slot = "7")]
		public void Initialize(IHZIMMUZDMM graph, BHCMVXNWZYE creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x81A19F0", Offset = "0x81A0DF0", VA = "0x1881A19F0", Slot = "5")]
		public void JKDPFPTLOFX(ADJOKRJYTUT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x81A1840", Offset = "0x81A0C40", VA = "0x1881A1840", Slot = "9")]
		public void IZSCRYHROFK(ADJOKRJYTUT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x81A1680", Offset = "0x81A0A80", VA = "0x1881A1680", Slot = "8")]
		public void HXBUQWNEFRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x81A1DE0", Offset = "0x81A11E0", VA = "0x1881A1DE0", Slot = "10")]
		public void ZWQMORKWWHJ(ADJOKRJYTUT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x81A1530", Offset = "0x81A0930", VA = "0x1881A1530", Slot = "11")]
		public void HNBUIMZQAGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x81A1C30", Offset = "0x81A1030", VA = "0x1881A1C30")]
		private bool XNBGEMDARGS(ADJOKRJYTUT a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class QEELOLOAZMQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly DETLCWEPBJK currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly YGKOEWMSPXW parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly YGKOEWMSPXW rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool VXOFBHVLOCP
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x81AC140", Offset = "0x81AB540", VA = "0x1881AC140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x81AC680", Offset = "0x81ABA80", VA = "0x1881AC680")]
			public SerializeNodeInSubgraph(DETLCWEPBJK currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] YGKOEWMSPXW parentNodeData, [Optional] YGKOEWMSPXW rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x81ABDE0", Offset = "0x81AB1E0", VA = "0x1881ABDE0")]
			public YGKOEWMSPXW CQVTSUWTJSM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x81AC5C0", Offset = "0x81AB9C0", VA = "0x1881AC5C0")]
			private YGKOEWMSPXW SIICUSSILLO([Out] YGKOEWMSPXW a, [Out] YGKOEWMSPXW b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x81AC3C0", Offset = "0x81AB7C0", VA = "0x1881AC3C0")]
			private YGKOEWMSPXW QZTWIXQIQTK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x81AC250", Offset = "0x81AB650", VA = "0x1881AC250")]
			private void LNVBATYOZPA(YGKOEWMSPXW a, YGKOEWMSPXW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x81ABF80", Offset = "0x81AB380", VA = "0x1881ABF80")]
			private void FWJFHDVQCZZ(YGKOEWMSPXW a, YGKOEWMSPXW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager KYSGMPHMQKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private IHZIMMUZDMM LKCBOZYZZFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private ZBMUIWLAHQL DSXFMDIERBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private QSVUMOHNGYG UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool LBELQSVYGZI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool WFIFWNQJEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x81AA680", Offset = "0x81A9A80", VA = "0x1881AA680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool DPSZRRXBKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x81A97B0", Offset = "0x81A8BB0", VA = "0x1881A97B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x81AB930", Offset = "0x81AAD30", VA = "0x1881AB930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x81AA610", Offset = "0x81A9A10", VA = "0x1881AA610")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x81AAAC0", Offset = "0x81A9EC0", VA = "0x1881AAAC0")]
		public ConnectableGraphData RDFMOQONVVW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x81AA1E0", Offset = "0x81A95E0", VA = "0x1881AA1E0")]
		public ConnectableGraphData ENSDJZXBAAA(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x81AA470", Offset = "0x81A9870", VA = "0x1881AA470")]
		public void HONTDRLTXJP(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x81A9710", Offset = "0x81A8B10", VA = "0x1881A9710")]
		public void CIDCVZZXLJL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x81AA1B0", Offset = "0x81A95B0", VA = "0x1881AA1B0")]
		public void ENNGXVUIXWL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x81AA8C0", Offset = "0x81A9CC0", VA = "0x1881AA8C0")]
		private void OFTJLAVCMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x81AB600", Offset = "0x81AAA00", VA = "0x1881AB600")]
		private YGKOEWMSPXW WMOZAFDHAQK(DETLCWEPBJK a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x81A93D0", Offset = "0x81A87D0", VA = "0x1881A93D0")]
		private static void ATKWDCYUJOQ(DETLCWEPBJK a, bool b, YGKOEWMSPXW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x81A9E20", Offset = "0x81A9220", VA = "0x1881A9E20")]
		private void DHLRCNUHIYH(DETLCWEPBJK a, bool b, YGKOEWMSPXW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x81A9680", Offset = "0x81A8A80", VA = "0x1881A9680")]
		private YGKOEWMSPXW BFLRWLRFMWW(DETLCWEPBJK a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x81AADC0", Offset = "0x81AA1C0", VA = "0x1881AADC0")]
		private bool VZHLNKMDLWU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x81A97D0", Offset = "0x81A8BD0", VA = "0x1881A97D0")]
		private bool CXCMOOSVIAB(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x81AAAA0", Offset = "0x81A9EA0", VA = "0x1881AAAA0")]
		private bool QAHQEADPPEX(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x81AA500", Offset = "0x81A9900", VA = "0x1881AA500")]
		private static bool IPCGTJVVCOW(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x81AB040", Offset = "0x81AA440", VA = "0x1881AB040")]
		public static bool WBFJCHWWLIO(YGKOEWMSPXW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x81AB2D0", Offset = "0x81AA6D0", VA = "0x1881AB2D0")]
		private QLJARVWWUTL WHPXJCROTYE(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x81AA040", Offset = "0x81A9440", VA = "0x1881AA040")]
		private QLJARVWWUTL EKHIWFFPZGK(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x81AAC30", Offset = "0x81AA030", VA = "0x1881AAC30")]
		private QLJARVWWUTL TQEDWKOUGYN(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x81A6750", Offset = "0x81A5B50", VA = "0x1881A6750")]
		private static Guid USMNAZAHRCP(YGKOEWMSPXW a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x81AA380", Offset = "0x81A9780", VA = "0x1881AA380")]
		private string GEPFHKQCXEK(YGKOEWMSPXW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x81AA6D0", Offset = "0x81A9AD0", VA = "0x1881AA6D0")]
		private bool KOJZYOMFXZH(DETLCWEPBJK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x81AB6E0", Offset = "0x81AAAE0", VA = "0x1881AB6E0")]
		private static void YDHEVRHQVPH(DETLCWEPBJK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public QEELOLOAZMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public QLJARVWWUTL child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public QLJARVWWUTL parent;

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
		public ConnectableLink CTTPTJAMJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8199ED0", Offset = "0x81992D0", VA = "0x188199ED0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink GIZCFIQNUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8199EA0", Offset = "0x81992A0", VA = "0x188199EA0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8199F70", Offset = "0x8199370", VA = "0x188199F70")]
		public ConnectionOperationData(QLJARVWWUTL child, QLJARVWWUTL parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface IHZIMMUZDMM
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		ADJOKRJYTUT JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(MVKCOMEZCMQ manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HIZHJJYNGOV([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KUACUPZGYVK(QLJARVWWUTL a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EBWGASYSKUA(QLJARVWWUTL a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NQWPMUCYUMA(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OQJLETURXFZ();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BXYNDVFGQWD(Func<QLJARVWWUTL, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DMXZPCYPCLF(QLJARVWWUTL a, HashSet<QLJARVWWUTL> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<QLJARVWWUTL> PGMZOGNFJIT();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GXOKSVDROMU(QLJARVWWUTL a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IZJEYNGMLJG(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(ADJOKRJYTUT node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface ADJOKRJYTUT
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		QLJARVWWUTL KTETREYXSTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		ADJOKRJYTUT YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink ALNNLQPHLGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool NXTCYWFZFKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface SUHNFWRICLC : SNFMQJYQEXK.EMUIBFFLXGS
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DWRZVDJUYSA(QLJARVWWUTL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XYKVMWVZDUY(QLJARVWWUTL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VJPWHAGBKJL(QLJARVWWUTL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void APJOOBDUXGX(QLJARVWWUTL a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SUHNFWRICLC QJHURVGNMRE(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface BHCMVXNWZYE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, SUHNFWRICLC linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SUHNFWRICLC NOYJKJWAXZA();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HDJPDEPVRZW(SUHNFWRICLC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface QKECDIBEATX : BHFBCXBUTFS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYBVXZWJIST();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GBIACMDEIDU(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface ZBMUIWLAHQL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JKDPFPTLOFX(ADJOKRJYTUT a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(IHZIMMUZDMM graph, BHCMVXNWZYE linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HXBUQWNEFRE();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IZSCRYHROFK(ADJOKRJYTUT a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZWQMORKWWHJ(ADJOKRJYTUT a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HNBUIMZQAGX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class DETLCWEPBJK : ADJOKRJYTUT
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class YFWRGDYIMOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink CQWRUHXVKFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public DETLCWEPBJK LZDDLSBLNHE;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YFWRGDYIMOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x81ACC80", Offset = "0x81AC080", VA = "0x1881ACC80")]
			internal bool SFCOPYUCNSB(ADJOKRJYTUT a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink WRIITFIHPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<DETLCWEPBJK> BBQMLARKSHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DETLCWEPBJK ATVEBFVIAJB;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink ALNNLQPHLGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4795300", Offset = "0x4794700", VA = "0x184795300", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x819A950", Offset = "0x8199D50", VA = "0x18819A950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DETLCWEPBJK ORUDLVOERZA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x819A990", Offset = "0x8199D90", VA = "0x18819A990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public ADJOKRJYTUT YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public QLJARVWWUTL KTETREYXSTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool NXTCYWFZFKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x819A980", Offset = "0x8199D80", VA = "0x18819A980", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool ZZURAQHENSO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x819A670", Offset = "0x8199A70", VA = "0x18819A670", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected DETLCWEPBJK XUVHPHBAVDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x819A220", Offset = "0x8199620", VA = "0x18819A220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x819AA70", Offset = "0x8199E70", VA = "0x18819AA70")]
		public DETLCWEPBJK(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x819A3B0", Offset = "0x81997B0", VA = "0x18819A3B0")]
		public DETLCWEPBJK JGRLELRKPON(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x819A4F0", Offset = "0x81998F0", VA = "0x18819A4F0")]
		public DETLCWEPBJK KSOTHBNNPDP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x819A6C0", Offset = "0x8199AC0", VA = "0x18819A6C0")]
		public DETLCWEPBJK Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8199FE0", Offset = "0x81993E0", VA = "0x188199FE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x819A8A0", Offset = "0x8199CA0", VA = "0x18819A8A0")]
		public DETLCWEPBJK Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x819A240", Offset = "0x8199640", VA = "0x18819A240")]
		private static void IZJEYNGMLJG(DETLCWEPBJK a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x819A3A0", Offset = "0x81997A0", VA = "0x18819A3A0", Slot = "9")]
		public void IZJEYNGMLJG(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x819A130", Offset = "0x8199530", VA = "0x18819A130")]
		public static DETLCWEPBJK DPYNFIVZQEB(DETLCWEPBJK a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface QSVUMOHNGYG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool WFIFWNQJEEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> HVURHQQZDNJ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<JCSDFORPEFX> FQFOLDMOBXV;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DWRZVDJUYSA(LegacyConnectableManager a, ZWCDIWYLDPO b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GVBNOWABNID(QLJARVWWUTL a, QLJARVWWUTL b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KQMVPZAFFVT(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void QWVSIRAYETS(ConnectableGraphData a, [Optional] JCSDFORPEFX b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class JHNMZHSTKSA
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x819AE30", Offset = "0x819A230", VA = "0x18819AE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x819ADF0", Offset = "0x819A1F0", VA = "0x18819ADF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x819ADA0", Offset = "0x819A1A0", VA = "0x18819ADA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class ZOZGUGSPKBV : QSVUMOHNGYG, IDisposable, OJLSFYCMAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager KYSGMPHMQKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private ZWCDIWYLDPO HVNLXEQCCQU;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool WFIFWNQJEEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x81AD1C0", Offset = "0x81AC5C0", VA = "0x1881AD1C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x81ADC50", Offset = "0x81AD050", VA = "0x1881ADC50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView UEURKORRJPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x81ACE80", Offset = "0x81AC280", VA = "0x1881ACE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> HVURHQQZDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x81ADC90", Offset = "0x81AD090", VA = "0x1881ADC90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x81ADD20", Offset = "0x81AD120", VA = "0x1881ADD20", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JCSDFORPEFX> FQFOLDMOBXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x81AD340", Offset = "0x81AC740", VA = "0x1881AD340", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x81ACF20", Offset = "0x81AC320", VA = "0x1881ACF20", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x81ACFC0", Offset = "0x81AC3C0", VA = "0x1881ACFC0", Slot = "10")]
		public void DWRZVDJUYSA(LegacyConnectableManager a, ZWCDIWYLDPO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x81AD050", Offset = "0x81AC450", VA = "0x1881AD050", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x81AD0A0", Offset = "0x81AC4A0", VA = "0x1881AD0A0", Slot = "11")]
		public void GVBNOWABNID(QLJARVWWUTL a, QLJARVWWUTL b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x81AD220", Offset = "0x81AC620", VA = "0x1881AD220", Slot = "12")]
		public void KQMVPZAFFVT(QLJARVWWUTL a, int b, QLJARVWWUTL c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x81AD3E0", Offset = "0x81AC7E0", VA = "0x1881AD3E0", Slot = "13")]
		public void QWVSIRAYETS(ConnectableGraphData a, [Optional] JCSDFORPEFX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x81AD730", Offset = "0x81ACB30", VA = "0x1881AD730")]
		[RPCMethod]
		private void RpcMasterReparentNodes(QLJARVWWUTL objectToReparent, int objectToReparentSlotIndex, QLJARVWWUTL newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x81AD540", Offset = "0x81AC940", VA = "0x1881AD540")]
		[RPCMethod]
		private void RpcMasterModifyNode(QLJARVWWUTL connectableToModify, QLJARVWWUTL expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x81ADB20", Offset = "0x81ACF20", VA = "0x1881ADB20")]
		[RPCMethod]
		private void RpcReparentNodes(QLJARVWWUTL objectToReparent, int objectToReparentSlotIndex, QLJARVWWUTL newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x81ADA30", Offset = "0x81ACE30", VA = "0x1881ADA30")]
		[RPCMethod]
		private void RpcModifyNode(QLJARVWWUTL connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x81AD500", Offset = "0x81AC900", VA = "0x1881AD500")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZOZGUGSPKBV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, SUHNFWRICLC, SNFMQJYQEXK.EMUIBFFLXGS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x819BBF0", Offset = "0x819AFF0", VA = "0x18819BBF0", Slot = "4")]
		private void TLSZKLOQWAD(QLJARVWWUTL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x819BD70", Offset = "0x819B170", VA = "0x18819BD70", Slot = "5")]
		private void UWMAROHFDBJ(QLJARVWWUTL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x819B7D0", Offset = "0x819ABD0", VA = "0x18819B7D0", Slot = "6")]
		private void EEKGCGLAFVO(QLJARVWWUTL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x819BA00", Offset = "0x819AE00", VA = "0x18819BA00", Slot = "7")]
		private void RVJGXUAUZXG(QLJARVWWUTL a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x819B930", Offset = "0x819AD30", VA = "0x18819B930", Slot = "8")]
		private SUHNFWRICLC FCWJDFRMNDR(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x819B9A0", Offset = "0x819ADA0", VA = "0x18819B9A0", Slot = "9")]
		private void NKVAVODULVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class BGUKWJDZBQG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3362740", Offset = "0x3361B40", VA = "0x183362740")]
		public static EUQWOTOFFMN<a> JCMFNYKRVIQ<a>(this XRSJVGYQFTW a)
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
