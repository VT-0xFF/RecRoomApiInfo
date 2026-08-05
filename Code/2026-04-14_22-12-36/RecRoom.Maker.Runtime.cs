using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RRUI.Data;
using RRUI.Dialogs;
using RecRoom.Core.Creation.Inventions;
using RecRoom.Core.DataStructures;
using RecRoom.Creation;
using RecRoom.Foundation;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Maker.Core;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using RecRoom.RendererV1;
using RecRoom.Tools;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Maker_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98C8B90", Offset = "0x98C7790", VA = "0x1898C8B90", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public readonly struct OutlineRequest : IEquatable<OutlineRequest>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class LDVEMAPXJJB : QMNJKQGWLUI<OutlineRequest>
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool ZTVEKVOKXHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x98C8970", Offset = "0x98C7570", VA = "0x1898C8970")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x98C8A70", Offset = "0x98C7670", VA = "0x1898C8A70")]
			public bool SELOQUMTFRU(ObjectLocalId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98C89B0", Offset = "0x98C75B0", VA = "0x1898C89B0")]
			public OutlineRequest MLPODCSVDIC(ObjectLocalId a)
			{
				return default(OutlineRequest);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98C8A90", Offset = "0x98C7690", VA = "0x1898C8A90")]
			private int WEEYQUGSMVH(ObjectLocalId a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x98C8B50", Offset = "0x98C7750", VA = "0x1898C8B50")]
			public LDVEMAPXJJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum RequestPriority
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			UgcGameplaySystem,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			ContentCreationTool,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			PlayerDirectInteraction,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			HackStandinPriorityToDistinguishNone
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum RequestMode
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			TARGETED_OBJECT,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			ALL_UNDER_ROOT_CONNECTABLE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			ALL_SNAP_POINT_GRAPH_OBJECTS
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly OutlineRequest None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly RequestPriority Priority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly ObjectLocalId Requester;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly RequestMode Mode;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98C93F0", Offset = "0x98C7FF0", VA = "0x1898C93F0")]
		public OutlineRequest(ObjectLocalId requester, RequestPriority priority = RequestPriority.UgcGameplaySystem, RequestMode mode = RequestMode.TARGETED_OBJECT)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98C9330", Offset = "0x98C7F30", VA = "0x1898C9330")]
		public static bool IQJYWSDTJLC(OutlineRequest a, OutlineRequest b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98C9200", Offset = "0x98C7E00", VA = "0x1898C9200", Slot = "4")]
		public bool Equals(OutlineRequest other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98C9140", Offset = "0x98C7D40", VA = "0x1898C9140", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98C92B0", Offset = "0x98C7EB0", VA = "0x1898C92B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NZABLYHNRTO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RequestStartOutlining(OutlineRequest request);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestStopOutlining(ObjectLocalId requester, OutlineRequest.RequestMode mode);
	}
}
namespace RecRoom.Maker
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class VRKWEQUXZTS
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static DRWWZAXJWQZ<Vector3> PDIUYMYBDDG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static DRWWZAXJWQZ<Vector3> EILARANQQSZ;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x98C9A10", Offset = "0x98C8610", VA = "0x1898C9A10", Slot = "4")]
		protected virtual void KYGMUSQWNYU(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x98C9980", Offset = "0x98C8580", VA = "0x1898C9980", Slot = "5")]
		protected virtual void AUOPRTGQCKR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected VRKWEQUXZTS()
		{
		}
	}
}
namespace RecRoom.Maker.MarqueeHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class MOUJRVUJRQK : VRKWEQUXZTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98C8C40", Offset = "0x98C7840", VA = "0x1898C8C40")]
		public void NIWWHQIFKHJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98C8C10", Offset = "0x98C7810", VA = "0x1898C8C10")]
		public void ELGLZOMVKFQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98C8C70", Offset = "0x98C7870", VA = "0x1898C8C70")]
		public MOUJRVUJRQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ICJJLJUFNSG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ProfilerMarker FBUYYBMNIEX;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static ProfilerMarker OQRJTLUYRPX;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly string ZWKNIFTSPAL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly string HASOEXMAZFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly int[] FHBCACXZYCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int[] IUYSVAZIIOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GameObject CELPDWQRPXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MeshCollider ZKZKMLEFTEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GameObject NWOHXZBXFNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MeshFilter DEUGENXSNXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Mesh FKEOSDRDNZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Mesh WZPHCEBPPTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Plane[] ZZDEHOQGYLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Collider[] EPCHOXRUVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private List<ObjectLocalId> RYWMXYTYRMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private List<Collider> EGFQFVKYHFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector3[] PCGHYLJYVIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 LBYMENZNNIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 JWUNXRBYUZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion KYVLQFQUOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Vector3[] NAKDSMGIDCP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Mesh BXVDGBXVJNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x98C4C80", Offset = "0x98C3880", VA = "0x1898C4C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Mesh ZQYWYRMPQJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x98C4C30", Offset = "0x98C3830", VA = "0x1898C4C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int LZJTFRTFMMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x97E6F10", Offset = "0x97E5B10", VA = "0x1897E6F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<Collider> OEISLYYOJJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x98C67C0", Offset = "0x98C53C0", VA = "0x1898C67C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98C7070", Offset = "0x98C5C70", VA = "0x1898C7070")]
		public ICJJLJUFNSG(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98C4B40", Offset = "0x98C3740", VA = "0x1898C4B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98C56E0", Offset = "0x98C42E0", VA = "0x1898C56E0")]
		public void MRZYNNVHFNR(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98C57B0", Offset = "0x98C43B0", VA = "0x1898C57B0")]
		public void NEZENIUJUIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98C61B0", Offset = "0x98C4DB0", VA = "0x1898C61B0")]
		private IEnumerable<Collider> YCTSIJGUNQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98C5D40", Offset = "0x98C4940", VA = "0x1898C5D40")]
		public void QAQHDWLRRQP(List<ObjectLocalId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98C5820", Offset = "0x98C4420", VA = "0x1898C5820")]
		private void OIZFJQVDZAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98C49E0", Offset = "0x98C35E0", VA = "0x1898C49E0")]
		private void CLQDYNKVKNY(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98C5960", Offset = "0x98C4560", VA = "0x1898C5960")]
		private void OJIQALCBSGK(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98C4CD0", Offset = "0x98C38D0", VA = "0x1898C4CD0")]
		private void LQBBPWBOCSF(Vector2 a, Vector2 b, Camera c, Vector2 d, Vector2 e, Vector3 f, Vector3 g, Vector3 h, Vector3 i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98C67D0", Offset = "0x98C53D0", VA = "0x1898C67D0")]
		private void YQMSSTXUOQC(Camera a, Vector3 b, Vector3 c, Vector3 d, Vector3 e, Vector3 f, Vector3 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98C55D0", Offset = "0x98C41D0", VA = "0x1898C55D0")]
		private void MNCECUSEWZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98C5F90", Offset = "0x98C4B90", VA = "0x1898C5F90")]
		private void RSIGFNCFISH(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98C5640", Offset = "0x98C4240", VA = "0x1898C5640")]
		private void MOCLMUJGOBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class WKPXOQOJFBV<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private OBOHJKFLCUW<a> NCUUVGFWQMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KNNZAGSWBGJ<a> ULLNKFIVXTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<a> EKXYKJDUJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<a> QHQGQMGQNBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<a> UXIGNVLMCCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<a> MSDBFTSIMSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private List<a> GLPXLNIRBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private List<a> ZDCTMDKXZXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OngoingSelectionMode JKIZXJABDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private MOUJRVUJRQK HGVXMXVGPHY;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85CF0B0", Offset = "0x85CDCB0", VA = "0x1885CF0B0")]
		public WKPXOQOJFBV(OBOHJKFLCUW<a> a, KNNZAGSWBGJ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85CEFE0", Offset = "0x85CDBE0", VA = "0x1885CEFE0")]
		public void Start(OngoingSelectionMode mode = OngoingSelectionMode.Add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE00", Offset = "0x85CCA00", VA = "0x1885CDE00")]
		public void RMPWGJRTIPO(IEnumerable<Collider> a, List<a> b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85CF080", Offset = "0x85CDC80", VA = "0x1885CF080")]
		public bool YZISAFOAUMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85CDD80", Offset = "0x85CC980", VA = "0x1885CDD80")]
		[CompilerGenerated]
		private bool NCTXUPIWHPA(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85CDDC0", Offset = "0x85CC9C0", VA = "0x1885CDDC0")]
		[CompilerGenerated]
		private bool NCZERWCTRAJ(a a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum OngoingSelectionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Add,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Remove
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class CGHRLVEFOTF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ShapeColor LPXTJPZIKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ShapeMaterial KSFJLDIUTJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float SVFPOYRRLZF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x98C4470", Offset = "0x98C3070", VA = "0x1898C4470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98C4490", Offset = "0x98C3090", VA = "0x1898C4490")]
		public CGHRLVEFOTF(ShapeColor a, ShapeMaterial b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98C4330", Offset = "0x98C2F30", VA = "0x1898C4330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98C43E0", Offset = "0x98C2FE0", VA = "0x1898C43E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class CreationOperationException : Exception, EHSVRPIYIAT
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public abstract string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98C4990", Offset = "0x98C3590", VA = "0x1898C4990")]
		protected CreationOperationException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NonSuccessCreationResultException : CreationOperationException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly CreationResult CreationResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly PlayerId RequestingPlayerActorNumber;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x98C9110", Offset = "0x98C7D10", VA = "0x1898C9110", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98C9040", Offset = "0x98C7C40", VA = "0x1898C9040")]
		public NonSuccessCreationResultException(CreationResult creationResult, int requestingPlayerActorNumber)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class UserFriendlyStringCreationException : CreationOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD1EC20", Offset = "0xD1D820", VA = "0x180D1EC20", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98C9910", Offset = "0x98C8510", VA = "0x1898C9910")]
		public UserFriendlyStringCreationException(string userFacingString)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ShapeSwatchInfo
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct JsonShapeSwatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int c;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public int m;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public float u;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x98C87F0", Offset = "0x98C73F0", VA = "0x1898C87F0")]
			public JsonShapeSwatch(ShapeSwatchInfo swatch)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct JsonShapeSwatches
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public JsonShapeSwatch[] s;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98C8820", Offset = "0x98C7420", VA = "0x1898C8820")]
			public JsonShapeSwatches(ShapeSwatchInfo[] swatches)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ShapeColor ShapeColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public ShapeMaterial ShapeMaterialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float UVScale;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float DefaultUVScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD9A780", Offset = "0xD99380", VA = "0x180D9A780")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x98C9720", Offset = "0x98C8320", VA = "0x1898C9720")]
		public ShapeSwatchInfo(ShapeColor colorId, ShapeMaterial materialId, float uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98C9560", Offset = "0x98C8160", VA = "0x1898C9560")]
		public static ShapeSwatchInfo[] QUHFYIOOOVR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98C96B0", Offset = "0x98C82B0", VA = "0x1898C96B0")]
		public static string YNUDWWCBYVE(ShapeSwatchInfo[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98C9490", Offset = "0x98C8090", VA = "0x1898C9490")]
		public ShapeSwatchInfo Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98C9440", Offset = "0x98C8040", VA = "0x1898C9440")]
		public bool BVIACZNRYPP(ShapeSwatchInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x98C9400", Offset = "0x98C8000", VA = "0x1898C9400")]
		public bool BVIACZNRYPP(ShapeMaterial a, ShapeColor b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98C9520", Offset = "0x98C8120", VA = "0x1898C9520")]
		public bool MDEZICGIIEB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DRMJENJPDUH<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public VPUQGLZDKRM ABZJFCZFCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF3130", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Collider[] LLZDOGNUBWV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Renderer[] YJYZAMPQAWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<VPUQGLZDKRM> ZSIUVSKKCTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x98C4830", Offset = "0x98C3430", VA = "0x1898C4830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x98C48E0", Offset = "0x98C34E0", VA = "0x1898C48E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x98C44F0", Offset = "0x98C30F0", VA = "0x1898C44F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x98C45A0", Offset = "0x98C31A0", VA = "0x1898C45A0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x98C45F0", Offset = "0x98C31F0", VA = "0x1898C45F0")]
		public void SetIConfigurable(VPUQGLZDKRM newConfigurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98C4500", Offset = "0x98C3100", VA = "0x1898C4500")]
		public void ChangeCollidersAndRenderers(Collider[] newColliders, Renderer[] newRenderers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x98C4720", Offset = "0x98C3320", VA = "0x1898C4720")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4F5AA00", Offset = "0x4F59600", VA = "0x184F5AA00")]
		public void RunConfigurationSpecialActions(VPUQGLZDKRM configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98C47B0", Offset = "0x98C33B0", VA = "0x1898C47B0")]
		public ConfigurableSubpiece()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface XXISAEMCTEG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool OUPBYSRFUKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AddIsAnimated(object token);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RemoveIsAnimated(object token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface OANTJKUIXTT
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<CGHRLVEFOTF> GetColorableSnapshots();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JLPZANBTBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurablePiece(ConfigurableSubpiece subPiece);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UnregisterConfigurablePiece(ConfigurableSubpiece subPiece);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ConfigurableSubpiece GetConfigurableSubpiece(Collider collider);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface AOCHKDJPTZG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GameObject DCEMLZFKLGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Guid DSPDRQQGPCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Vector3 CUJKMYEUBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Vector3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Quaternion MNNDKHLHEHU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Quaternion LFODOXUWQHP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float TLPBRAXDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		float EFHRNQBDZAF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Vector3 VPLDKFMUHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Vector3 XKMCKVDXJTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool LUBDOGFAIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		VPUQGLZDKRM ABZJFCZFCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[CanBeNull]
		UWQCXHXCFSQ ACIQARQGEVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action WBMVKZKKSPL;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool CanUpdateDeformation(Vector3 deformationDirection, float deformationFactor, float minAxisScale, Space relativeTo);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void UpdateDeformation(Vector3 deformationDirection, float deformationFactor, bool scalingAlongFixedAxis, Space relativeTo);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool CanBeRaycasted(Collider collider);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface YEYSYELGHTH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool GNZYSNBCOFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool KWKQANCCKIE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		Vector3 QWSKOJBPXTH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Vector3 VPCIEWFELQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool XTUHSMBWUTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool OHIEAHSTJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool DTQEGMRECWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool UULPYXKVUHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool QRYOGXFLBOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool LJVCUYRSSAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool WESXLCTSVKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool VXTOICROFPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool KERZTOPSQTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnCreatedBySpawning();

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnCreatedFromTemplate();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnSelected();

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnTranslationStart();

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OnRotationStart();

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnScaleStart();

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnDeformStart();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OnTranslated();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnRotated();

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OnScaled();

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OnDeformed(Vector3 previousPosition);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OnTranslationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OnRotationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OnScaleFinished();

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void OnDeformationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OnDeselected();

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnHoverStart(ToolMode toolMode, Collider hitCollider, OutlineRequest outlineRequest);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void OnHovering(ToolMode toolMode, Collider hitCollider);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OnHoverFinished(ToolMode toolMode, ObjectLocalId outlineRequester, OutlineRequest.RequestMode requestMode);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void Translate(Vector3 displacementWorldSpace);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void Rotate(Quaternion angularDisplacementWorldSpace);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool Scale(float scaleFactor);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task DeleteAsync();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface YPFLQYVDLQT
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XNGLSZAXDUA([In] Vector3 origin, [In] Vector3 direction, Vector3 a, Vector3 b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface QWGOCFFEQFM
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool YOKUFGKYOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		SMMLEVHGFEC QEIISCYMPBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestMasterDespawn();
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface DCTOGMFFTAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool PZJYTCQQFWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		NUAUZMIGHGX QIAGKCVRCWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<bool> BZLXFZZKSFQ;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LocalPlayerTakeAuthority();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TransferOwnership(int actorNumber);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		DDFOJMMWCEL GetCulprit(CreationResult failureReason);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface SBEAVQIGYYW
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IEnumerable<NavMeshSupport.Restriction> DBRHCYFMAXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AddNavMeshSupportRestriction(NavMeshSupport.Restriction restriction);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RemoveNavMeshSupportRestriction(NavMeshSupport.Restriction restriction);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface PVCYVJIWFHZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface ITIYASHTPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestRPCReset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface RYTERVXPPBT
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool SWIOIBEEWZM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool XRPCHBREGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface EYQYPXGNJRG
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int CDXQOHGEBPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RenderSelection(SelectionEffectType? selectionEffectType);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RenderOutline(OutlineEffectType? outlineType);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RenderWorldFadeMask();

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Bounds GetWorldBounds();

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CreationResult CanBeSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface UKWWIFUWNYR
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool SAGTQTMVLXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		CanSaveObjectIntoInventionResultType IUKVXGPRKFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool UFUWKQBVDDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool MLLAEZXKSSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool IVYCYALHHLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool ECDAXBEFMCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool CYPOSACJUJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		IEnumerable<Collider> PUMWSLZMXCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		RotatedBounds? DAEDPWDNTSH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool XZYVYWNGEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool VTJCHOFRTVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CostInfo GetSandboxResourceCost(bool verifyIntegrity = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface LOXVOYABXEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult CanPerformUndoRedoOnObject();

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GetTransformationDataForUndoRedo([Out] Vector3 position, [Out] Quaternion rotation, [Out] float uniformScale, [Out] Vector3 deformationScale);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetTransformationDataForUndoRedo(Vector3? position, Quaternion? rotation, float? uniformScale, Vector3? deformationScale);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface CRRXSLXHWPH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object RLVFKCRHLTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Type ZHPQMYKNURH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Guid YDZZFWJVUUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface VPUQGLZDKRM
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		IReadOnlyList<IDynamicUIElementData> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<string> QBXQSFNIDNP;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<VPUQGLZDKRM> HDVMYMAMLTI;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<DialogType, AHTULJUYAHT> LGLIYYXBKUF;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action IYCFMFBLMZW;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ConfigurableWillHide();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface STNQYZEXRZG
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action ZSBZTANZRXQ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface ASGOYUMJVYR : VPUQGLZDKRM, GWMHUNAVMSR
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IEnumerable<GWMHUNAVMSR> OWMASYRRXES
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurableAddOn(GWMHUNAVMSR newSubConfigurable);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface GWMHUNAVMSR
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<IDynamicUIElementData> GetConfigurableDynamicUI([Optional] IEnumerable<GWMHUNAVMSR> configurables);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface ZVTJANMVHRL
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool KARNVRMCFBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool UBEZTJOVEQV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct NavMeshSupport
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public delegate NavMeshSupportStatus Restriction();

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly IEnumerable<Restriction> NoRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<Restriction> restrictions;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IEnumerable<Restriction> NOQNIZRXWDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x98C8EC0", Offset = "0x98C7AC0", VA = "0x1898C8EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x98C8CC0", Offset = "0x98C78C0", VA = "0x1898C8CC0")]
		public void Add(Restriction restriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x98C8F20", Offset = "0x98C7B20", VA = "0x1898C8F20")]
		public bool Remove(Restriction restriction)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum NavMeshSupportStatus
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		NotSupported,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Supported
	}
}
namespace RecRoom.Core.Creation.Inventions
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct TrialInventionInfo : DXSUQDVXHUN
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int TrialSpawnTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x30BE910", Offset = "0x30BD510", VA = "0x1830BE910", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x98C9770", Offset = "0x98C8370", VA = "0x1898C9770")]
		public TrialInventionInfo(int trialSpawnTime, int spawningPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface IMRDEBWWFRC : ILAEJSJUYLB
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		static readonly int ERKFZBZOMIR;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		static readonly Guid XJPSODXALKM;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Guid IBMXQCAIFFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		long VGFOKZYUDMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[Obsolete("This is not used - version tracking is done at the server level as collections of InventionId")]
		int ZLNBWHWGZYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x98C7580", Offset = "0x98C6180", VA = "0x1898C7580")]
		static IMRDEBWWFRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Obsolete("This is not used by anything and does not give us full provenance tracking")]
	public interface EASRULWDICE
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Obsolete("This is not currently consumed and does not give us full provenance tracking, however it does contain information that may prevent 'contamination' of invention contents by other non-monetizable inventions")]
		bool OXLDXCBAJKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface UWQCXHXCFSQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool DHXLCAGDNJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		IMRDEBWWFRC HGUUQQRBGKM();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		[CanBeNull]
		EASRULWDICE DPSWAHAWNGQ();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YLIUEECBWJH(Guid a, long b, int c, bool d);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YLIUEECBWJH(UWQCXHXCFSQ a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SerializeTo(InventionPieceData data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class XTZGVAEWRXL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x98C9B80", Offset = "0x98C8780", VA = "0x1898C9B80")]
		public static void DeserializeFrom(this UWQCXHXCFSQ that, InventionPieceData inventionPieceData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface ILAEJSJUYLB
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool FEKFEDBSSPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		DXSUQDVXHUN TQFWXYBYJMN();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TQFWXYBYJMN([Out] TrialInventionInfo a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DEEHLNGRINM(DDFOJMMWCEL a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HTMPPAMSVHD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface DXSUQDVXHUN
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		int TrialSpawnTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class InventionTrackingViaSynchronizedField : UWQCXHXCFSQ, IMRDEBWWFRC, ILAEJSJUYLB, DXSUQDVXHUN, EASRULWDICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MQWYDUUYRCG<Guid, ObscuredLong, ObscuredInt, ObscuredBool> CYQMZUDMOYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MRMSVPCQTKH<ObscuredBool, ObscuredInt, ObscuredInt> QVSTYEVZDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private RRNetworkBehavior VZNWCMOFUPJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private Guid IBMXQCAIFFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x98C7BC0", Offset = "0x98C67C0", VA = "0x1898C7BC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private long VGFOKZYUDMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x98C7660", Offset = "0x98C6260", VA = "0x1898C7660")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private int ZLNBWHWGZYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x98C7E80", Offset = "0x98C6A80", VA = "0x1898C7E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private bool OXLDXCBAJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x98C7B20", Offset = "0x98C6720", VA = "0x1898C7B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private bool FEKFEDBSSPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x98C77C0", Offset = "0x98C63C0", VA = "0x1898C77C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private int VEYTHQCZBWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x98C7A80", Offset = "0x98C6680", VA = "0x1898C7A80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private int BFBVDZZIEYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x98C7F10", Offset = "0x98C6B10", VA = "0x1898C7F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool DHXLCAGDNJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x98C7A00", Offset = "0x98C6600", VA = "0x1898C7A00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private Guid TLDEEYGVZUU
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x98C7BC0", Offset = "0x98C67C0", VA = "0x1898C7BC0", Slot = "10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private long BTWOXVUSJAR
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x98C75F0", Offset = "0x98C61F0", VA = "0x1898C75F0", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private int QKQDRWBRWLN
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x98C7B10", Offset = "0x98C6710", VA = "0x1898C7B10", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private int QJWFFLRAWYA
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x98C7BB0", Offset = "0x98C67B0", VA = "0x1898C7BB0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private int JCULVGTNFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x98C7620", Offset = "0x98C6220", VA = "0x1898C7620", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool TEMYPMKQZBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x98C7610", Offset = "0x98C6210", VA = "0x1898C7610", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool VCKATTIALZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x98C7600", Offset = "0x98C6200", VA = "0x1898C7600", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x98C84D0", Offset = "0x98C70D0", VA = "0x1898C84D0")]
		public InventionTrackingViaSynchronizedField(RRNetworkBehavior owningBehavior, string syncKey, Guid instanceId, long inventionId, int versionNumber, bool originallyFromOtherInvention)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x98C7D70", Offset = "0x98C6970", VA = "0x1898C7D70", Slot = "9")]
		public void SerializeTo(InventionPieceData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x98C7700", Offset = "0x98C6300", VA = "0x1898C7700")]
		public static InventionPieceData GVMQUCPAIPH(Guid a, long b, int c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x98C7630", Offset = "0x98C6230", VA = "0x1898C7630", Slot = "5")]
		public IMRDEBWWFRC HGUUQQRBGKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x98C7630", Offset = "0x98C6230", VA = "0x1898C7630", Slot = "6")]
		public EASRULWDICE DPSWAHAWNGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x98C7FA0", Offset = "0x98C6BA0", VA = "0x1898C7FA0", Slot = "7")]
		public void YLIUEECBWJH(Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x98C8170", Offset = "0x98C6D70", VA = "0x1898C8170", Slot = "8")]
		public void YLIUEECBWJH(UWQCXHXCFSQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98C7D40", Offset = "0x98C6940", VA = "0x1898C7D40", Slot = "14")]
		private DXSUQDVXHUN RDUROZWFTNU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98C7E20", Offset = "0x98C6A20", VA = "0x1898C7E20", Slot = "15")]
		public bool TQFWXYBYJMN([Out] TrialInventionInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98C7850", Offset = "0x98C6450", VA = "0x1898C7850", Slot = "16")]
		private void HMULVXMAHDP(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98C7C30", Offset = "0x98C6830", VA = "0x1898C7C30", Slot = "17")]
		private void PKCDRODXKCW()
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
