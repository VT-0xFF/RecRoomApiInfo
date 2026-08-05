using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.Toolkit.HighPerformance.Helpers;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal static class ArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1CBFFE0", Offset = "0x1CBEDE0", VA = "0x181CBFFE0")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1CC10A0", Offset = "0x1CBFEA0", VA = "0x181CC10A0")]
		public static Span<int> GetTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DebugEntityInfoExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1CC1110", Offset = "0x1CBFF10", VA = "0x181CC1110")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[BurstCompile]
		private struct SetComponentDataArrayJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3C85360", Offset = "0x3C84160", VA = "0x183C85360", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile]
		private struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			[WriteOnly]
			public ArchetypeChunkComponentType<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x34929C0", Offset = "0x34917C0", VA = "0x1834929C0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3491EF0", Offset = "0x3490CF0", VA = "0x183491EF0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3491FF0", Offset = "0x3490DF0", VA = "0x183491FF0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x34923F0", Offset = "0x34911F0", VA = "0x1834923F0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CC1130", Offset = "0x1CBFF30", VA = "0x181CC1130")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OKBEHKLMDFC<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ALNJFLGFPMH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::OKBEHKLMDFC<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x40CA960", Offset = "0x40C9760", VA = "0x1840CA960", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C930", Offset = "0x2F9B730", VA = "0x182F9C930")]
		[DebuggerHidden]
		public ALNJFLGFPMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x40CA780", Offset = "0x40C9580", VA = "0x1840CA780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x40CA920", Offset = "0x40C9720", VA = "0x1840CA920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> CBAADNPBNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream PIJFOMBKKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream BEFKDKFOEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf BOCJENDJFJM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x749E00", Offset = "0x748C00", VA = "0x180749E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3262070", Offset = "0x3260E70", VA = "0x183262070")]
	private OKBEHKLMDFC(byte[] NGFFBKNAABM, Action<Protobuf> CBAADNPBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4135F20", Offset = "0x4134D20", VA = "0x184135F20")]
	public static global::OKBEHKLMDFC<Protobuf> DIMOBFAICBM<Data>(ReadOnlySpan<byte> KLGAKJLGGNF, ReadOnlySpan<Data> PDGNCDHKFCJ, Action<Protobuf> CBAADNPBNBM)
	{
		return default(global::OKBEHKLMDFC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3261EE0", Offset = "0x3260CE0", VA = "0x183261EE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3261F20", Offset = "0x3260D20", VA = "0x183261F20", Slot = "4")]
	[IteratorStateMachine(typeof(global::OKBEHKLMDFC<>.ALNJFLGFPMH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3262020", Offset = "0x3260E20", VA = "0x183262020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FOENOPHFAID<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] NGFFBKNAABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf BOCJENDJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream PIJFOMBKKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream FBFJLCPBLEB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37A3D10", Offset = "0x37A2B10", VA = "0x1837A3D10")]
	private FOENOPHFAID(byte[] NGFFBKNAABM, in Protobuf BOCJENDJFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F08180", Offset = "0x2F06F80", VA = "0x182F08180")]
	public static global::FOENOPHFAID<Protobuf> DIMOBFAICBM<T>(ReadOnlySpan<T> PDGNCDHKFCJ)
	{
		return default(global::FOENOPHFAID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37A3CE0", Offset = "0x37A2AE0", VA = "0x1837A3CE0")]
	public void NDGDLLPPGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37A3C50", Offset = "0x37A2A50", VA = "0x1837A3C50")]
	public ByteString GOKACGHGFNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37A3B20", Offset = "0x37A2920", VA = "0x1837A3B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EPDPCFODGDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream PIJFOMBKKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream BEFKDKFOEII;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1060", Offset = "0x1CBFE60", VA = "0x181CC1060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EJGHKHOAAJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] NGFFBKNAABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream PIJFOMBKKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream FBFJLCPBLEB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0F30", Offset = "0x1CBFD30", VA = "0x181CC0F30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EHMJJCJIFKF
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void PJIFBKDLIGI(this EKGLDANHPKF CGFIKJKJOPN, NativeArray<Entity> JFFJECJPHEB, [Optional][CallerFilePath] string OMONKEHCPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void PJIFBKDLIGI(this EKGLDANHPKF CGFIKJKJOPN, string CCEKFDNIAPD, NativeArray<Entity> JFFJECJPHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void PJIFBKDLIGI(this EKGLDANHPKF CGFIKJKJOPN, string OMONKEHCPCK, NativeArray<Entity> JFFJECJPHEB, bool AACLNJEGPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void GDMBKDCIBIB(this EKGLDANHPKF CGFIKJKJOPN, NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> PADELIJHEBE, [Optional][CallerFilePath] string OMONKEHCPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void GDMBKDCIBIB(this EKGLDANHPKF CGFIKJKJOPN, string OMONKEHCPCK, NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> PADELIJHEBE, bool AACLNJEGPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x348A310", Offset = "0x3489110", VA = "0x18348A310")]
	public static void LCHNHCGFOKD<T>(this EKGLDANHPKF CGFIKJKJOPN, string CCEKFDNIAPD, NativeArray<Entity> JFFJECJPHEB, NativeList<T> CPLKBCGCHAN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x348A2D0", Offset = "0x34890D0", VA = "0x18348A2D0")]
	public static void LCHNHCGFOKD<T>(this EKGLDANHPKF CGFIKJKJOPN, string CCEKFDNIAPD, NativeArray<Entity> JFFJECJPHEB, NativeArray<T> CPLKBCGCHAN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void LCHNHCGFOKD<T>(this EKGLDANHPKF CGFIKJKJOPN, string OMONKEHCPCK, NativeArray<Entity> JFFJECJPHEB, NativeArray<T> CPLKBCGCHAN, bool AACLNJEGPKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x348A260", Offset = "0x3489060", VA = "0x18348A260")]
	public static void KMGHLGKJBGP<T>(this EKGLDANHPKF CGFIKJKJOPN, NativeList<T> CPLKBCGCHAN, [Optional][CallerFilePath] string OMONKEHCPCK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x348A230", Offset = "0x3489030", VA = "0x18348A230")]
	public static void KMGHLGKJBGP<T>(this EKGLDANHPKF CGFIKJKJOPN, NativeArray<T> CPLKBCGCHAN, [Optional][CallerFilePath] string OMONKEHCPCK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void KMGHLGKJBGP<T>(this EKGLDANHPKF CGFIKJKJOPN, string OMONKEHCPCK, NativeArray<T> CPLKBCGCHAN, bool AACLNJEGPKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void BJKAIOOIAKB(this EKGLDANHPKF CGFIKJKJOPN, EntityQuery EFCFIFNMPEK, [Optional][CallerFilePath] string OMONKEHCPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void BJKAIOOIAKB(this EKGLDANHPKF CGFIKJKJOPN, string CCEKFDNIAPD, EntityQuery EFCFIFNMPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void BJKAIOOIAKB(this EKGLDANHPKF CGFIKJKJOPN, string OMONKEHCPCK, EntityQuery EFCFIFNMPEK, bool AACLNJEGPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x348A3A0", Offset = "0x34891A0", VA = "0x18348A3A0")]
	public static void NIINDMIACPN<T, T2>(this EKGLDANHPKF CGFIKJKJOPN, string CCEKFDNIAPD, EntityQuery EFCFIFNMPEK) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void NIINDMIACPN<T, T2>(this EKGLDANHPKF CGFIKJKJOPN, string OMONKEHCPCK, EntityQuery EFCFIFNMPEK, bool AACLNJEGPKC) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KMKIHICBCMB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HHDIDEJHIBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MEDPNFPBJDK(Entity DNMNICOEECM, object DPODOOAHECI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEOHFEPOHHD(Entity DNMNICOEECM, object DPODOOAHECI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHDOAJCEAOL(Entity DNMNICOEECM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHDOAJCEAOL(IHMDJLDFGCF ODABKCNLMCP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> KKDABDPAIOK(Entity DNMNICOEECM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DICFIIJABJC(Entity DNMNICOEECM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class INNNKMFPNPD<TComponentData, TValue> : global::EHDBDBMNLKF<TValue>, IDisposable where TComponentData : struct, KMKIHICBCMB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class JKJOLAGEIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> GHOABBJLFEA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EKAGFOMELON
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3346810", Offset = "0x3345610", VA = "0x183346810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36F5990", Offset = "0x36F4790", VA = "0x1836F5990")]
		public bool BAMPMIFHFJH(out TValue DPJGMDFEIDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36F5B00", Offset = "0x36F4900", VA = "0x1836F5B00")]
		public void EKGLGHAFJEH(object DPODOOAHECI, TValue DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x36F5BB0", Offset = "0x36F49B0", VA = "0x1836F5BB0")]
		public bool PPEAGPDBOCM(object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36F5A50", Offset = "0x36F4850", VA = "0x1836F5A50")]
		public int DMLIELKNFBC(object DPODOOAHECI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x36F5C30", Offset = "0x36F4A30", VA = "0x1836F5C30")]
		public JKJOLAGEIAI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<JKJOLAGEIAI> HFJPOABLBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::PNLCOEEFLCB<IHMDJLDFGCF, JKJOLAGEIAI> LFIMDLBHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3742AC0", Offset = "0x37418C0", VA = "0x183742AC0")]
	public INNNKMFPNPD(EntityManager ECFOMHOIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3742900", Offset = "0x3741700", VA = "0x183742900", Slot = "4")]
	public void MEDPNFPBJDK(Entity DNMNICOEECM, object DPODOOAHECI, TValue DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3742790", Offset = "0x3741590", VA = "0x183742790", Slot = "5")]
	public bool JEOHFEPOHHD(Entity DNMNICOEECM, object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3742610", Offset = "0x3741410", VA = "0x183742610", Slot = "6")]
	public bool BAMPMIFHFJH(Entity DNMNICOEECM, out TValue DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37426E0", Offset = "0x37414E0", VA = "0x1837426E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3742A40", Offset = "0x3741840", VA = "0x183742A40")]
	private void OGMIICEMEFB(JKJOLAGEIAI HDPNAJDCAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x37424A0", Offset = "0x37412A0", VA = "0x1837424A0")]
	private bool ADLCMCLHFLL(Entity DNMNICOEECM, out IHMDJLDFGCF ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3742700", Offset = "0x3741500", VA = "0x183742700")]
	private void HLHFADLNCLB(Entity DNMNICOEECM, IHMDJLDFGCF ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3742A20", Offset = "0x3741820", VA = "0x183742A20")]
	private bool OGHDLFDICKB(IHMDJLDFGCF ODABKCNLMCP, out JKJOLAGEIAI HDPNAJDCAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3742550", Offset = "0x3741350", VA = "0x183742550")]
	private JKJOLAGEIAI APJIPIGGCCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EHDBDBMNLKF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEDPNFPBJDK(Entity DNMNICOEECM, object DPODOOAHECI, TValue DPJGMDFEIDL);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEOHFEPOHHD(Entity DNMNICOEECM, object DPODOOAHECI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BAMPMIFHFJH(Entity DNMNICOEECM, out TValue DPJGMDFEIDL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IHMDJLDFGCF : global::DPOFMDICJLA<IHMDJLDFGCF>, GHFDCEBDMDI, IEquatable<IHMDJLDFGCF>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly IHMDJLDFGCF LMFLNMNCHIB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D30", Offset = "0x8D1B30", VA = "0x1808D2D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1F40", Offset = "0x1CC0D40", VA = "0x181CC1F40", Slot = "8")]
	public bool Equals(IHMDJLDFGCF BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1F90", Offset = "0x1CC0D90", VA = "0x181CC1F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JGINJLKIIMG<T> : HHDIDEJHIBI, IDisposable where T : struct, KMKIHICBCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> HFJPOABLBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::PNLCOEEFLCB<IHMDJLDFGCF, HashSet<object>> LFIMDLBHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDA00", Offset = "0x3AFC800", VA = "0x183AFDA00")]
	public JGINJLKIIMG(EntityManager ECFOMHOIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCE90", Offset = "0x3AFBC90", VA = "0x183AFCE90", Slot = "4")]
	public bool MEDPNFPBJDK(Entity DNMNICOEECM, object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3AFBD60", Offset = "0x3AFAB60", VA = "0x183AFBD60", Slot = "5")]
	public bool JEOHFEPOHHD(Entity DNMNICOEECM, object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD110", Offset = "0x3AFBF10", VA = "0x183AFD110", Slot = "6")]
	public bool MHDOAJCEAOL(Entity DNMNICOEECM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD230", Offset = "0x3AFC030", VA = "0x183AFD230", Slot = "7")]
	public bool MHDOAJCEAOL(IHMDJLDFGCF ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC4B0", Offset = "0x3AFB2B0", VA = "0x183AFC4B0", Slot = "8")]
	public IEnumerable<object> KKDABDPAIOK(Entity DNMNICOEECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCA30", Offset = "0x3AFB830", VA = "0x183AFCA30", Slot = "11")]
	public IEnumerable<object> KKDABDPAIOK(IHMDJLDFGCF ODABKCNLMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB680", Offset = "0x3AFA480", VA = "0x183AFB680", Slot = "9")]
	public bool DICFIIJABJC(Entity DNMNICOEECM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB9D0", Offset = "0x3AFA7D0", VA = "0x183AFB9D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD690", Offset = "0x3AFC490", VA = "0x183AFD690")]
	private void OGMIICEMEFB(HashSet<object> HDPNAJDCAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA870", Offset = "0x3AF9670", VA = "0x183AFA870")]
	private bool ADLCMCLHFLL(Entity DNMNICOEECM, out IHMDJLDFGCF ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAFF0", Offset = "0x3AF9DF0", VA = "0x183AFAFF0")]
	private bool DFHFOPFLOJB(Entity DNMNICOEECM, out IHMDJLDFGCF ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD4B0", Offset = "0x3AFC2B0", VA = "0x183AFD4B0")]
	private void MMKBIMOBJMA(Entity DNMNICOEECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFBB20", Offset = "0x3AFA920", VA = "0x183AFBB20")]
	private void HLHFADLNCLB(Entity DNMNICOEECM, IHMDJLDFGCF ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAF30", Offset = "0x3AF9D30", VA = "0x183AFAF30")]
	private bool CBPMNAMNFGB(IHMDJLDFGCF ODABKCNLMCP, out HashSet<object> HDPNAJDCAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3AFACD0", Offset = "0x3AF9AD0", VA = "0x183AFACD0")]
	private HashSet<object> APJIPIGGCCN()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OACDIAFELNI : global::BAJKHJMOEIO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4120", Offset = "0x1CC2F20", VA = "0x181CC4120", Slot = "4")]
	public float AIIDIIDIAIJ(float3 DPJGMDFEIDL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HJJJCMPDMFI : global::BAJKHJMOEIO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1C90", Offset = "0x1CC0A90", VA = "0x181CC1C90", Slot = "4")]
	public float AIIDIIDIAIJ(float3 DPJGMDFEIDL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JALECMPDENJ : global::BAJKHJMOEIO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2060", Offset = "0x1CC0E60", VA = "0x181CC2060", Slot = "4")]
	public float AIIDIIDIAIJ(float3 DPJGMDFEIDL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BLIHLCPHPMC : global::BAJKHJMOEIO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x101D6D0", Offset = "0x101C4D0", VA = "0x18101D6D0", Slot = "4")]
	public int AIIDIIDIAIJ(int3 DPJGMDFEIDL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DKOMHDODBNE : global::BAJKHJMOEIO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0990", Offset = "0x1CBF790", VA = "0x181CC0990", Slot = "4")]
	public int AIIDIIDIAIJ(int3 DPJGMDFEIDL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LLNAJCLPHAP : global::BAJKHJMOEIO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2600", Offset = "0x1CC1400", VA = "0x181CC2600", Slot = "4")]
	public int AIIDIIDIAIJ(int3 DPJGMDFEIDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OEKIAFMFIDF : DCDFAAPOFND
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type OBKPMEJOIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2030", Offset = "0x1CC0E30", VA = "0x181CC2030")]
	public OEKIAFMFIDF(Type OGJOOHDCNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IOADNKMGCAK : OEKIAFMFIDF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2030", Offset = "0x1CC0E30", VA = "0x181CC2030")]
	public IOADNKMGCAK(Type OGJOOHDCNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IMIEFJOLIGG : OEKIAFMFIDF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type IHIIGPKOOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1FE0", Offset = "0x1CC0DE0", VA = "0x181CC1FE0")]
	public IMIEFJOLIGG(Type AGAENHKOKGG, Type OGJOOHDCNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OOMLJFNMBNM : OEKIAFMFIDF
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2030", Offset = "0x1CC0E30", VA = "0x181CC2030")]
	public OOMLJFNMBNM(Type OGJOOHDCNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LFNIFJENOAD : DCDFAAPOFND
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public LFNIFJENOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OJPFBMJMNJL : DCDFAAPOFND
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JGAMAFNCPCL BJJPLCBJKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
		[CompilerGenerated]
		get
		{
			return default(JGAMAFNCPCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4130", Offset = "0x1CC2F30", VA = "0x181CC4130")]
	public OJPFBMJMNJL(JGAMAFNCPCL POLNGKBPPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class AHFPALIMFBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly PLMMGPNIKJM DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PLMMGPNIKJM CPBIHJAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1CBFF90", Offset = "0x1CBED90", VA = "0x181CBFF90")]
	public AHFPALIMFBF(PLMMGPNIKJM DJCIICEJFGH, EntityManager ECFOMHOIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2B9EF00", Offset = "0x2B9DD00", VA = "0x182B9EF00")]
	public bool PDDKLHEAAKA<T>(Entity DNMNICOEECM) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D490", Offset = "0x2B9C290", VA = "0x182B9D490")]
	public bool JCOOONONOLB<T>(Entity DNMNICOEECM, out T DPJGMDFEIDL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D520", Offset = "0x2B9C320", VA = "0x182B9D520")]
	public T MFAHPIMAODD<T>(Entity DNMNICOEECM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2B9CC90", Offset = "0x2B9BA90", VA = "0x182B9CC90")]
	private ComponentType CKIDGFIFIKN<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CBFEC0", Offset = "0x1CBECC0", VA = "0x181CBFEC0")]
	private ComponentType CKIDGFIFIKN(Type LAKBKKJKBPK)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class FPPGDBCGJNK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected FPPGDBCGJNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class KNBGFECNDDJ<View, Data> : LKKPMGMGFIA where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType CCEECJGPMFN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type IAMNCKNBFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4376380", Offset = "0x4375180", VA = "0x184376380", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type MLJLKGLLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x43771C0", Offset = "0x4375FC0", VA = "0x1843771C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int PFBLLIPAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4377AF0", Offset = "0x43768F0", VA = "0x184377AF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4377BB0", Offset = "0x43769B0", VA = "0x184377BB0")]
	public Data MLPOGIOGDOG(Entity DNMNICOEECM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4376740", Offset = "0x4375540", VA = "0x184376740")]
	public Data HDBLMKKDODF(Entity DNMNICOEECM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View GIDAJDJMKCM(Entity DNMNICOEECM);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F650", Offset = "0x2F0E450", VA = "0x182F0F650", Slot = "15")]
	protected internal override T GIDAJDJMKCM<T>(Entity DNMNICOEECM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390")]
	protected KNBGFECNDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class LKKPMGMGFIA : LNOFNLNFGAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic FCJJABEPFON;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x855580", Offset = "0x854380", VA = "0x180855580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type IAMNCKNBFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type MLJLKGLLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int PFBLLIPAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type PJCMPIJCADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xE509B0", Offset = "0xE4F7B0", VA = "0x180E509B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int BFEDNOKEJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1CC2410", Offset = "0x1CC1210", VA = "0x181CC2410", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private KOFEPFEJINF[] KBMNLOEDIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xE508E0", Offset = "0xE4F6E0", VA = "0x180E508E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual KOFEPFEJINF[] ACKMLANOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC2540", Offset = "0x1CC1340", VA = "0x181CC2540", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ENKBPHIDFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1CC2230", Offset = "0x1CC1030", VA = "0x181CC2230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1CC22F0", Offset = "0x1CC10F0", VA = "0x181CC22F0")]
	public void FKIENGHPLFJ(EntityManager ECFOMHOIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	protected LNOFNLNFGAL LAIKLLEFLBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T GIDAJDJMKCM<T>(Entity DNMNICOEECM) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2480", Offset = "0x1CC1280", VA = "0x181CC2480", Slot = "8")]
	public (uint, uint) MGDMPDOKGLO(Entity DNMNICOEECM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2260", Offset = "0x1CC1060", VA = "0x181CC2260", Slot = "9")]
	public bool EJOAHFIKKEM(Entity DNMNICOEECM, (uint order, uint change) LLNMOPOJDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected LKKPMGMGFIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class HLFALOALELO<Data> : CCKGGMKEPJM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data JLGGJMINNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3940E60", Offset = "0x393FC60", VA = "0x183940E60", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7D30D0", Offset = "0x7D1ED0", VA = "0x1807D30D0", Slot = "8")]
	protected virtual bool NFEBCKMEODN(ReadOnlySpan<Data> PDGNCDHKFCJ, IFAEDNBIFMG LAKAALEJDAJ, out ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "9")]
	protected virtual bool HELPOIILIGH(int LLNMOPOJDNH, Span<Data> PDGNCDHKFCJ, in ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3940F00", Offset = "0x393FD00", VA = "0x183940F00", Slot = "5")]
	internal sealed override bool NFEBCKMEODN(ref Unity.Entities.Chunk LJKLLDMPOPK, int HJANCPDHNPG, IFAEDNBIFMG LAKAALEJDAJ, out ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3940880", Offset = "0x393F680", VA = "0x183940880", Slot = "6")]
	internal sealed override bool HELPOIILIGH(int LLNMOPOJDNH, ref Unity.Entities.Chunk LJKLLDMPOPK, int HJANCPDHNPG, in ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CA70", Offset = "0x2F0B870", VA = "0x182F0CA70")]
	protected global::FOENOPHFAID<Protobuf> PIJGPKCMAHH<Protobuf>(ReadOnlySpan<Data> PDGNCDHKFCJ) where Protobuf : IMessage, new()
	{
		return default(global::FOENOPHFAID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C9E0", Offset = "0x2F0B7E0", VA = "0x182F0C9E0")]
	protected global::OKBEHKLMDFC<Protobuf> HOKAAGMFKLF<Protobuf>(ReadOnlySpan<byte> KLGAKJLGGNF, ReadOnlySpan<Data> PDGNCDHKFCJ, Action<Protobuf> CBAADNPBNBM) where Protobuf : IMessage, new()
	{
		return default(global::OKBEHKLMDFC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390")]
	protected HLFALOALELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class CCKGGMKEPJM
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0140", Offset = "0x1CBEF40", VA = "0x181CC0140", Slot = "5")]
	internal virtual bool NFEBCKMEODN(ref Unity.Entities.Chunk LJKLLDMPOPK, int HJANCPDHNPG, IFAEDNBIFMG LAKAALEJDAJ, out ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "6")]
	internal virtual bool HELPOIILIGH(int LLNMOPOJDNH, ref Unity.Entities.Chunk LJKLLDMPOPK, int HJANCPDHNPG, in ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected CCKGGMKEPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BAJKHJMOEIO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo AIIDIIDIAIJ(TFrom DPJGMDFEIDL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LHCFCIKCEJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HMKGAHJANLF(T DPJGMDFEIDL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct COFBEDIOICP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::BAJKHJMOEIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> PACNJDHEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> HMLJAJDHPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap CIAILAMJPDB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct HPEDJEALPIG<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::BAJKHJMOEIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> DMBGHGGCJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> HMLJAJDHPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap CIAILAMJPDB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct NHKEIGDKAKK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NMNEIOPHHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> PACNJDHEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> HMLJAJDHPDK;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3957820", Offset = "0x3956620", VA = "0x183957820", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct MJCLNLBIKDN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NMNEIOPHHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> PACNJDHEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> IPMICNLEMOI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct ANFBLMAPODK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::BAJKHJMOEIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> APMFOCPNFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> HMLJAJDHPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap CIAILAMJPDB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct JOIPIILGKJJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OGJOOHDCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> DNGMAKGMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> FPKGAMINAPF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct EAKEJHPONGI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OGJOOHDCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> DNGMAKGMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> FPKGAMINAPF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x40F5730", Offset = "0x40F4530", VA = "0x1840F5730", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct PDPFFDCHGMG<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> PACNJDHEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> IPMICNLEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, PDIIEEBMKOH> BNBKCANFBLO;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51E75C0", Offset = "0x51E63C0", VA = "0x1851E75C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct LCMHNEKHDKP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::BAJKHJMOEIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> PACNJDHEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> IPMICNLEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, PDIIEEBMKOH> BNBKCANFBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap CIAILAMJPDB;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct AEAEOHGOCGM<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::LHCFCIKCEJM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> PACNJDHEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> IPMICNLEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate CIAILAMJPDB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct LEFKELJDOBJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity OGJOOHDCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> DNGMAKGMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> JIHJAFDGNLK;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1CC21A0", Offset = "0x1CC0FA0", VA = "0x181CC21A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct FKDAGHIOJBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity OGJOOHDCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> DNGMAKGMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> JIHJAFDGNLK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1290", Offset = "0x1CC0090", VA = "0x181CC1290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CNMBLECOHFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class EDGODHMKADP
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0290", Offset = "0x3ACF090", VA = "0x183AD0290")]
	public static bool COAIENAPCBA<T>(this NativeArray<Entity> DNGMAKGMFCK, EntityManager ECFOMHOIDDI, Allocator CMCENMLGNBG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PNILFJDOOMK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class PMLNNAEIMIB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public PMLNNAEIMIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FEFAKPKFGGK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public FEFAKPKFGGK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> GGAHFNEONMK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5170", Offset = "0x1CC3F70", VA = "0x181CC5170")]
	public PNILFJDOOMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IPAEMKEBOML
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LOADCGHBMEN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct AMGADDPGECB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct PKMLBECLOHG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AMGADDPGECB<TFrom> KICGHGEEADG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> IDEEEMMOHPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct HEKOKHKGOKG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct LBJALPGNPLN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal HEKOKHKGOKG<TFrom> KICGHGEEADG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> IDEEEMMOHPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct LMAPAIKBDLI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct FGFCGBMKAHC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal LMAPAIKBDLI<TFrom> KICGHGEEADG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> IDEEEMMOHPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct GKJHNPNEJKB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct HGLJMDPIFDC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal GKJHNPNEJKB<TFrom> KICGHGEEADG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> IDEEEMMOHPP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class AONHBADOGFO
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DAIHEAKBIPB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C28560", Offset = "0x3C27360", VA = "0x183C28560")]
	public static NativeList<T> OMEJMADDKDL<T>(this NativeArray<T> ILAJIJOHCFD, Allocator CMCENMLGNBG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JFENGJOJCFC
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3219980", Offset = "0x3218780", VA = "0x183219980")]
	public static NativeArray<T> INCGBKHPHFM<T>(this NativeList<Entity> ILAJIJOHCFD, EntityManager ECFOMHOIDDI, Allocator CMCENMLGNBG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3219780", Offset = "0x3218580", VA = "0x183219780")]
	public static NativeArray<T> INCGBKHPHFM<T>(this NativeArray<Entity> ILAJIJOHCFD, EntityManager ECFOMHOIDDI, Allocator CMCENMLGNBG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class ONEFADDMDMF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct KAGPMFGLEDP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct LIKMAMFBDPP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public KAGPMFGLEDP<TFrom> IDEEEMMOHPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> PACNJDHEICH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct EPKENEIBMFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct MNMOEMLHAEO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public EPKENEIBMFJ<TFrom> IDEEEMMOHPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> PACNJDHEICH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct KEFNEDCNPCM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct FMIDMJNAECP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public KEFNEDCNPCM<TFrom> IDEEEMMOHPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> PACNJDHEICH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BHNMKMAPEEG
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KGEFMLKMHLB
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DKHNEKNIDKM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> PACNJDHEICH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct MJFBFOHALJK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> PACNJDHEICH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct FAHKJHIGBAD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> PACNJDHEICH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct KJMJMNDEOAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator CMCENMLGNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> PACNJDHEICH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IGDFGGMDJAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class COBDMCGEHFE
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3340490", Offset = "0x333F290", VA = "0x183340490")]
	public static NativeList<Entity> ELOHEKOILEJ<T>(this NativeArray<Entity> DNGMAKGMFCK, EntityManager ECFOMHOIDDI, Allocator CMCENMLGNBG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class ANBLFIEOBCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ECHOOICOCOB
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface LPNBEBEAALL
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LFNFIADMPHI
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class CGODFMHDPNG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0160", Offset = "0x1CBEF60", VA = "0x181CC0160")]
	public static bool JGHOHHMJHAP(Type LAKBKKJKBPK, Type CJAMNNLNHMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class EFEOHLKMHPC<Attribute, BaseClass> : global::HMHDAIFHJKP<BaseClass>, NBPLFNCIPFH where Attribute : OEKIAFMFIDF
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly EKGLDANHPKF CGFIKJKJOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string CCEKFDNIAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> PIDMPFEDFNF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x410F440", Offset = "0x410E240", VA = "0x18410F440")]
	public EFEOHLKMHPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x410EEA0", Offset = "0x410DCA0", VA = "0x18410EEA0", Slot = "4")]
	public bool DOMBPGEJHPH(int EDBPGCEKEHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x410F090", Offset = "0x410DE90", VA = "0x18410F090", Slot = "5")]
	public global::JMMBMFDPPCF<BaseClass> MIPPEENJFOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x410EF90", Offset = "0x410DD90", VA = "0x18410EF90", Slot = "7")]
	protected virtual bool JGHOHHMJHAP(Type LAKBKKJKBPK, int KJAHFFMEEOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x410EE10", Offset = "0x410DC10", VA = "0x18410EE10", Slot = "8")]
	protected virtual int BGHNABNFCNJ(Type LAKBKKJKBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x410EF00", Offset = "0x410DD00", VA = "0x18410EF00")]
	public void EAJHEFOPBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x410F340", Offset = "0x410E140", VA = "0x18410F340", Slot = "6")]
	public void OBNDPKOJMJJ(Type LAKBKKJKBPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JMMBMFDPPCF<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> GIBBIBDKENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> ICNKIHFGFGD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> CIILJFCAGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3700B90", Offset = "0x36FF990", VA = "0x183700B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x37010E0", Offset = "0x36FFEE0", VA = "0x1837010E0")]
	public JMMBMFDPPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3700F40", Offset = "0x36FFD40", VA = "0x183700F40")]
	public JMMBMFDPPCF(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3700DC0", Offset = "0x36FFBC0", VA = "0x183700DC0")]
	internal void EKGLGHAFJEH(int EDBPGCEKEHE, BaseClass BINHKOFKAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E500", Offset = "0x2F0D300", VA = "0x182F0E500")]
	public bool FNBGPIILICL<T>(out BaseClass DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3700E40", Offset = "0x36FFC40", VA = "0x183700E40")]
	public bool FNBGPIILICL(Type GOCNKJILLJC, out BaseClass DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3700F10", Offset = "0x36FFD10", VA = "0x183700F10")]
	public bool JAAKKMAHHLN(int EDBPGCEKEHE, out BaseClass DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F210", Offset = "0x2F0E010", VA = "0x182F0F210")]
	public T HOJANJMKFPO<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3700EE0", Offset = "0x36FFCE0", VA = "0x183700EE0")]
	public BaseClass HOJANJMKFPO(Type KIHNFJCMDCP)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class KPPAEHCGBPA : global::EFEOHLKMHPC<IOADNKMGCAK, FPPGDBCGJNK>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2130", Offset = "0x1CC0F30", VA = "0x181CC2130")]
	public KPPAEHCGBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FGJFNLFJAEM : global::EFEOHLKMHPC<IMIEFJOLIGG, LKKPMGMGFIA>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1220", Offset = "0x1CC0020", VA = "0x181CC1220")]
	public FGJFNLFJAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class PPHOELLHOLC : global::EFEOHLKMHPC<OOMLJFNMBNM, CCKGGMKEPJM>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CC51F0", Offset = "0x1CC3FF0", VA = "0x181CC51F0")]
	public PPHOELLHOLC()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[KNPMBINOPIG(MLNJOBCAIAM.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> CBKHHLNLKPG;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
		private ComponentSystemTypes(List<Type> CBKHHLNLKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1CC05F0", Offset = "0x1CBF3F0", VA = "0x181CC05F0")]
		public static void EAJHEFOPBGE(List<Type> CBKHHLNLKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1CC0700", Offset = "0x1CBF500", VA = "0x181CC0700")]
		private void LBNHKNNPBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1CC0680", Offset = "0x1CBF480", VA = "0x181CC0680")]
		private bool JGHOHHMJHAP(Type LAKBKKJKBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1CC0590", Offset = "0x1CBF390", VA = "0x181CC0590")]
		private void BBECJJGDDFK(Type LAKBKKJKBPK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class MMMECBJBGPP : LNHODKLBMHC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2980", Offset = "0x1CC1780", VA = "0x181CC2980", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase IIKDJGDEJFK();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2930", Offset = "0x1CC1730", VA = "0x181CC2930")]
	protected ComponentSystemBase OEIFACKBAFF(params ComponentSystemBase[] LHNNPMPCLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x36643E0", Offset = "0x36631E0", VA = "0x1836643E0")]
	protected ComponentSystemBase OEIFACKBAFF<T>(params ComponentSystemBase[] LHNNPMPCLEE) where T : LNHODKLBMHC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x36643A0", Offset = "0x36631A0", VA = "0x1836643A0")]
	protected ComponentSystemBase OFFACIANEKB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x36643A0", Offset = "0x36631A0", VA = "0x1836643A0")]
	protected ComponentSystemBase KHLKLFJFOIN<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	protected MMMECBJBGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface HMHDAIFHJKP<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOMBPGEJHPH(int EDBPGCEKEHE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JMMBMFDPPCF<BaseClass> MIPPEENJFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LNHODKLBMHC : IFPLPONOGKA
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2610", Offset = "0x1CC1410", VA = "0x181CC2610", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public LNHODKLBMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class KDFOLIPKNOC : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2080", Offset = "0x1CC0E80", VA = "0x181CC2080")]
	public ComponentDataFromEntity PHMFPOCJLFN(int EDBPGCEKEHE, bool JEFIMODPPHF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2120", Offset = "0x1CC0F20", VA = "0x181CC2120", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	protected KDFOLIPKNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class JDAMMLFCKGM : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	protected JDAMMLFCKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class CLIEFILLAJL : KDFOLIPKNOC
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0340", Offset = "0x1CBF140", VA = "0x181CC0340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	protected void IEFBBADHFBO(string ENIJNHAJDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	protected CLIEFILLAJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class HFGHIEJENCO
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class IFPLPONOGKA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	protected IFPLPONOGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[KNPMBINOPIG(MLNJOBCAIAM.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5B90", Offset = "0x1CC4990", VA = "0x181CC5B90")]
		public static ComponentSystemGroup[] GECNHEKPGCL(World DJCIICEJFGH, EMBBFGFHCBJ JBEGKAGJOBD = EMBBFGFHCBJ.Default, bool MAIAAKLLKKP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1CC60B0", Offset = "0x1CC4EB0", VA = "0x181CC60B0")]
		private static Type[] PGGPCJOJDEP(EMBBFGFHCBJ JBEGKAGJOBD, bool MAIAAKLLKKP, ComponentSystemGroup[] IKPEKHPOHHJ, ComponentSystemGroup JBEOAOJKGJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5C60", Offset = "0x1CC4A60", VA = "0x181CC5C60")]
		private static ComponentSystemGroup[] JJLLHONGDFP(World DJCIICEJFGH, out ComponentSystemGroup JBEOAOJKGJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1CC58B0", Offset = "0x1CC46B0", VA = "0x181CC58B0")]
		internal static bool CMGPGBIFFKN(JGAMAFNCPCL POLNGKBPPLK, out HDMPPCBKAPM EAALJJOIKLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5F70", Offset = "0x1CC4D70", VA = "0x181CC5F70")]
		private static ComponentSystemGroup MCEKBCPDJBF(Type LAKBKKJKBPK, World DJCIICEJFGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5780", Offset = "0x1CC4580", VA = "0x181CC5780")]
		private static ComponentSystemGroup[] CHEEMIGMGLO(Type[] CBKHHLNLKPG, World DJCIICEJFGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5260", Offset = "0x1CC4060", VA = "0x181CC5260")]
		internal static void CDJMFHLFDFF(World DJCIICEJFGH, Type[] NODJAFPMFGA, ComponentSystemGroup[] IKPEKHPOHHJ, ComponentSystemGroup JBEOAOJKGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6050", Offset = "0x1CC4E50", VA = "0x181CC6050")]
		internal static bool MIIFCGADBJE(ComponentSystemBase PFKBGJMLAMC, ComponentSystemGroup[] IKPEKHPOHHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5B30", Offset = "0x1CC4930", VA = "0x181CC5B30")]
		private static void ELACCFODIPK(ComponentSystemGroup[] IKPEKHPOHHJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MNANNNFMJBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> IALLAMALHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> LHNNPMPCLEE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xCDACE0", Offset = "0xCD9AE0", VA = "0x180CDACE0")]
	public MNANNNFMJBB(Dictionary<Type, List<Type>> IALLAMALHIJ, HashSet<Type> LHNNPMPCLEE)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[KNPMBINOPIG(MLNJOBCAIAM.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class EBOBLEDPKAF : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private IEnumerable<Type> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public IEnumerable<Type> <>3__types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public RRFilterWorldSystems <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public RRFilterWorldSystems <>3__<>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
			[DebuggerHidden]
			public EBOBLEDPKAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1CC0C50", Offset = "0x1CBFA50", VA = "0x181CC0C50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1CC09B0", Offset = "0x1CBF7B0", VA = "0x181CC09B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1CC0CE0", Offset = "0x1CBFAE0", VA = "0x181CC0CE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1CC0C10", Offset = "0x1CBFA10", VA = "0x181CC0C10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x1CC0B60", Offset = "0x1CBF960", VA = "0x181CC0B60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1CC0B60", Offset = "0x1CBF960", VA = "0x181CC0B60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct JGCLPLOHBAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type GDJALLDPGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private EMBBFGFHCBJ JBEGKAGJOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool DFCPLHPKOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool HBIJDPICJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool MAIAAKLLKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> BDDAMGFBJFJ;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6610", Offset = "0x1CC5410", VA = "0x181CC6610")]
		public static RRFilterWorldSystems DIMOBFAICBM()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6D50", Offset = "0x1CC5B50", VA = "0x181CC6D50")]
		public RRFilterWorldSystems OEBJFIADNNJ(EMBBFGFHCBJ POLNGKBPPLK)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6D10", Offset = "0x1CC5B10", VA = "0x181CC6D10")]
		public RRFilterWorldSystems NOBGCGFOCHJ(IEnumerable<Type> CBKHHLNLKPG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6600", Offset = "0x1CC5400", VA = "0x181CC6600")]
		public RRFilterWorldSystems BIDPEKDILFE(bool FFNFOKFMHDK)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6C70", Offset = "0x1CC5A70", VA = "0x181CC6C70")]
		public RRFilterWorldSystems LBFLCBLOFPJ(bool MKCPCBOEECM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6C80", Offset = "0x1CC5A80", VA = "0x181CC6C80")]
		public MNANNNFMJBB LGHKLLIIDGC(Type[] DCILDKPDEHO)
		{
			return default(MNANNNFMJBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6AD0", Offset = "0x1CC58D0", VA = "0x181CC6AD0")]
		[IteratorStateMachine(typeof(EBOBLEDPKAF))]
		internal IEnumerable<Type> KFAEHOHFNNM(IEnumerable<Type> CBKHHLNLKPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1CC67F0", Offset = "0x1CC55F0", VA = "0x181CC67F0")]
		internal Dictionary<Type, List<Type>> JJJLCNIGPKE(IEnumerable<Type> CBKHHLNLKPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6B60", Offset = "0x1CC5960", VA = "0x181CC6B60")]
		private void LBEHCKKELFF(Dictionary<Type, List<Type>> PDECCELFEPJ, Type LAKBKKJKBPK, Type OMADJKLBDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6630", Offset = "0x1CC5430", VA = "0x181CC6630")]
		internal HashSet<Type> IOIPPOMCIOB(IEnumerable<Type> IKPEKHPOHHJ, Dictionary<Type, List<Type>> EJIPNPFMBNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6D60", Offset = "0x1CC5B60", VA = "0x181CC6D60")]
		internal bool OFDNJKHLHKA(Type LAKBKKJKBPK, EMBBFGFHCBJ JBEGKAGJOBD, bool MAIAAKLLKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1CC64A0", Offset = "0x1CC52A0", VA = "0x181CC64A0")]
		[CompilerGenerated]
		internal static void BDBNKKJEPFN(Type LAKBKKJKBPK, ref JGCLPLOHBAN P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class COODHAEGLLL
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool IPBOHCCFDFC;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0530", Offset = "0x1CBF330", VA = "0x181CC0530")]
	public static void FKIENGHPLFJ(bool JBCHDAAKNKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0370", Offset = "0x1CBF170", VA = "0x181CC0370")]
	private static void CILBAIPHMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class GNICJJMDMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1BA0", Offset = "0x1CC09A0", VA = "0x181CC1BA0")]
	public static ulong OLLGPMNMDCF(Type LAKBKKJKBPK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1BD0", Offset = "0x1CC09D0", VA = "0x181CC1BD0")]
	public static ulong OLLGPMNMDCF(string CCDKOOLMALC)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[KNPMBINOPIG(MLNJOBCAIAM.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct NNDHAMDCMJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong MEFOPDBKPNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong BLCNHGHDNMN;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA33D30", Offset = "0xA32B30", VA = "0x180A33D30")]
			public NNDHAMDCMJE(ulong NKEBICFGPNO, ulong MGHKBMGLKCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1CC3290", Offset = "0x1CC2090", VA = "0x181CC3290", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> HNCCHKKKCDF;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static NNDHAMDCMJE[] JCKDFMCCGBK;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool IPBOHCCFDFC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7C00", Offset = "0x1CC6A00", VA = "0x181CC7C00")]
		public static ulong NFKNBDLDNGC(int EDBPGCEKEHE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7B50", Offset = "0x1CC6950", VA = "0x181CC7B50")]
		public static int LGLNDABEEBA(ulong MGHKBMGLKCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7880", Offset = "0x1CC6680", VA = "0x181CC7880")]
		public static void FKIENGHPLFJ(bool JBCHDAAKNKO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7A70", Offset = "0x1CC6870", VA = "0x181CC7A70")]
		private static void KIKODJGDKPI(int LHNKFMMFKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7560", Offset = "0x1CC6360", VA = "0x181CC7560")]
		private static void DJIGKKCOPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7480", Offset = "0x1CC6280", VA = "0x181CC7480")]
		private static NNDHAMDCMJE CONFGDJOHJN(Type LAKBKKJKBPK)
		{
			return default(NNDHAMDCMJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1CC80F0", Offset = "0x1CC6EF0", VA = "0x181CC80F0")]
		private static ulong PIHNGEJDHJO(Type LAKBKKJKBPK, ulong MGHKBMGLKCE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7E40", Offset = "0x1CC6C40", VA = "0x181CC7E40")]
		private static void OIOHKKHEIKM(in NNDHAMDCMJE EFJCJDEAGGE, TypeManager.TypeInfo DPIIHPBGDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7C60", Offset = "0x1CC6A60", VA = "0x181CC7C60")]
		private static void NFMFPHDOFGD(NNDHAMDCMJE DPIIHPBGDFO, int EDBPGCEKEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7D60", Offset = "0x1CC6B60", VA = "0x181CC7D60")]
		private static void ODPBDHPPIOF(NNDHAMDCMJE DPIIHPBGDFO, int EDBPGCEKEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8060", Offset = "0x1CC6E60", VA = "0x181CC8060")]
		private static NNDHAMDCMJE PBOCINMCGBA(int EDBPGCEKEHE)
		{
			return default(NNDHAMDCMJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1CC7470", Offset = "0x1CC6270", VA = "0x181CC7470")]
		private static int BFFDGGEHNNE(int EDBPGCEKEHE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class GCDENNHAMAB
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly FGJFNLFJAEM KLIKEEMAIKE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly PPHOELLHOLC NCAFNMMLFFP;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly KPPAEHCGBPA DBJNHACALCJ;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> NAGHEDPFHJH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool IPBOHCCFDFC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::HMHDAIFHJKP<LKKPMGMGFIA> BOEJALDMGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1CC1830", Offset = "0x1CC0630", VA = "0x181CC1830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::HMHDAIFHJKP<CCKGGMKEPJM> HABACIDGNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1CC17D0", Offset = "0x1CC05D0", VA = "0x181CC17D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::HMHDAIFHJKP<FPPGDBCGJNK> OPIPLIENHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1CC1890", Offset = "0x1CC0690", VA = "0x181CC1890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1CC1320", Offset = "0x1CC0120", VA = "0x181CC1320")]
	public static void FKIENGHPLFJ(bool JBCHDAAKNKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1CC18F0", Offset = "0x1CC06F0", VA = "0x181CC18F0")]
	public static Type[] OOGGBKNDDFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class NFPKILACIKI
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> GOAPKLMIBME;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool IPBOHCCFDFC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2D00", Offset = "0x1CC1B00", VA = "0x181CC2D00")]
	public static int MGDMPDOKGLO(int EDBPGCEKEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2BE0", Offset = "0x1CC19E0", VA = "0x181CC2BE0")]
	public static void FKIENGHPLFJ(bool JBCHDAAKNKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2DA0", Offset = "0x1CC1BA0", VA = "0x181CC2DA0")]
	private static void NMKAPGJMBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2B90", Offset = "0x1CC1990", VA = "0x181CC2B90")]
	private static int FCKKJDKLDFF(Type LAKBKKJKBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC2C80", Offset = "0x1CC1A80", VA = "0x181CC2C80")]
	private static void KJHAHNAAJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class PLMMGPNIKJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World OGAHLDGOMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly AHFPALIMFBF BINHKOFKAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] IKPEKHPOHHJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World CPBIHJAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World KAFKEKECCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1259130", Offset = "0x1257F30", VA = "0x181259130")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AHFPALIMFBF PDMIOCKKDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::JMMBMFDPPCF<LKKPMGMGFIA> BOEJALDMGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::JMMBMFDPPCF<CCKGGMKEPJM> HABACIDGNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D4470", Offset = "0x6D3270", VA = "0x1806D4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::JMMBMFDPPCF<FPPGDBCGJNK> OPIPLIENHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A70", Offset = "0x6C4870", VA = "0x1806C5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D4460", Offset = "0x6D3260", VA = "0x1806D4460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> IGKGCEECDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1259170", Offset = "0x1257F70", VA = "0x181259170")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] FBEMCPHPOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4650", Offset = "0x1CC3450", VA = "0x181CC4650")]
	public static PLMMGPNIKJM FIBJBHJPNHH(string CCEKFDNIAPD, JGAMAFNCPCL POLNGKBPPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4C50", Offset = "0x1CC3A50", VA = "0x181CC4C50")]
	public PLMMGPNIKJM(string CCEKFDNIAPD, JGAMAFNCPCL POLNGKBPPLK = JGAMAFNCPCL.Simulation, EMBBFGFHCBJ JBEGKAGJOBD = EMBBFGFHCBJ.Default, bool JBCHDAAKNKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4330", Offset = "0x1CC3130", VA = "0x181CC4330")]
	public ComponentSystemBase BGBIGJDKMIG(Type LAKBKKJKBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x33F3340", Offset = "0x33F2140", VA = "0x1833F3340")]
	public T BGBIGJDKMIG<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4350", Offset = "0x1CC3150", VA = "0x181CC4350")]
	public void BGCLEFEKGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4B30", Offset = "0x1CC3930", VA = "0x181CC4B30")]
	public void MGNPGEJHJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4BF0", Offset = "0x1CC39F0", VA = "0x181CC4BF0")]
	public void PHAMDPMLGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4210", Offset = "0x1CC3010", VA = "0x181CC4210")]
	public void AFJNMEBKJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4B90", Offset = "0x1CC3990", VA = "0x181CC4B90")]
	public void NMBLOKKLEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4270", Offset = "0x1CC3070", VA = "0x181CC4270")]
	public void BBEAFIELDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1CC45F0", Offset = "0x1CC33F0", VA = "0x181CC45F0")]
	public void FFNHHNABDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4560", Offset = "0x1CC3360", VA = "0x181CC4560")]
	public void ELKEAMANNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1CC42D0", Offset = "0x1CC30D0", VA = "0x181CC42D0")]
	public void BEFFDAMDHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4490", Offset = "0x1CC3290", VA = "0x181CC4490")]
	public void CCEJPEDFOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1CC43B0", Offset = "0x1CC31B0", VA = "0x181CC43B0")]
	internal void CCDFIBIJDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4AB0", Offset = "0x1CC38B0", VA = "0x181CC4AB0")]
	private bool JJAGNMMGJGB(ComponentSystemGroup ALGIJJJDBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC46D0", Offset = "0x1CC34D0", VA = "0x181CC46D0")]
	private void FLNFIKOJGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC49A0", Offset = "0x1CC37A0", VA = "0x181CC49A0")]
	private ComponentSystemGroup[] GECNHEKPGCL(EMBBFGFHCBJ JBEGKAGJOBD, bool MAIAAKLLKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC44F0", Offset = "0x1CC32F0", VA = "0x181CC44F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum JGAMAFNCPCL
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class AFBEKHKEANO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public EMBBFGFHCBJ HDOCAGLLJMP;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum EMBBFGFHCBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface HDMPPCBKAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type KHAHPENEJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] GBCNPFICNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class LHHHLKNMCPG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool BNLDMLPCKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	protected LHHHLKNMCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class NNCCMFOGMLL : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public NNCCMFOGMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MACPOLEHCPP : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public MACPOLEHCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class IJJLGABGBKA : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public IJJLGABGBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class NCCILOIGODH : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public NCCILOIGODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class DEFCEKJCCGG : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public DEFCEKJCCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class DCGCALAGIBB : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public DCGCALAGIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class KAPEMOBMPCL : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public KAPEMOBMPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class BOELAJBNPJB : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public BOELAJBNPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class PHFMEECGKBE : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public PHFMEECGKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class GNJLGPCGPID : OJDOMMGGELL
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public GNJLGPCGPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class NLAFGDLINMH : OJDOMMGGELL
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public NLAFGDLINMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class MDFIICKECEC : OJDOMMGGELL
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public MDFIICKECEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class LOCGKPAFLNE : OJDOMMGGELL
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public LOCGKPAFLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[LDMGGBBOHCI(MNIFKKPEEPE.Application)]
public class OJDOMMGGELL : LHHHLKNMCPG
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool BNLDMLPCKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0130", Offset = "0x1CBEF30", VA = "0x181CC0130")]
	public OJDOMMGGELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class PDCFFDBAKMH : DCDFAAPOFND
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public PDCFFDBAKMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class EGKDLEKLLND
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void GNHJPJAKCCI<From, To>(From IDEEEMMOHPP, ref To AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class IECBNCAEONC<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static GNHJPJAKCCI<From, To> GDEDPDPGDLP;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public IECBNCAEONC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0D30", Offset = "0x1CBFB30", VA = "0x181CC0D30")]
	static EGKDLEKLLND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2E90", Offset = "0x3AD1C90", VA = "0x183AD2E90")]
	public static void FADFDCMNGFP<T>(GNHJPJAKCCI<T, T> FINDKPFNHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x347CD60", Offset = "0x347BB60", VA = "0x18347CD60")]
	public static void FADFDCMNGFP<From, To>(GNHJPJAKCCI<From, To> FINDKPFNHPI, GNHJPJAKCCI<To, From> BJKLKAPJCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x347D8A0", Offset = "0x347C6A0", VA = "0x18347D8A0")]
	public static void FADFDCMNGFP<From, To>(GNHJPJAKCCI<From, To> GDEDPDPGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3481500", Offset = "0x3480300", VA = "0x183481500")]
	public static GNHJPJAKCCI<From, To> KAANPKKDEFI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x34806D0", Offset = "0x347F4D0", VA = "0x1834806D0")]
	public static void JEIFDJOGNMH<From, To>(From IDEEEMMOHPP, ref To AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class IFAEDNBIFMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> MKMPKLAMFIN;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
	public IFAEDNBIFMG(NativeArray<EntityRemapUtility.EntityRemapInfo> MKMPKLAMFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DAF0", VA = "0x18090ECF0")]
	public Entity AOJPKOBOKLD(Entity PHBCKPEIIAK)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class NLPIDOJKOPN
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> HFHPDHLBOAF;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1CC30A0", Offset = "0x1CC1EA0", VA = "0x181CC30A0")]
	public static bool JLFDFBLCBAF(ulong JJOJGACMMLF, uint LLNMOPOJDNH, out string CCEKFDNIAPD)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct CCHDHKDHMCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int NCHPHHOHCKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int NPFJJNLPIKO;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8A9760", Offset = "0x8A8560", VA = "0x1808A9760")]
			public CCHDHKDHMCO(int DJIEOHJNDEK, int LLNMOPOJDNH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct ICALIGFLGNM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch IBCKILPAMFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long NLAOCFOCLMO;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long ADKIIELFNPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x1CC1EE0", Offset = "0x1CC0CE0", VA = "0x181CC1EE0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long BFGADEKJIAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x1CC1DB0", Offset = "0x1CC0BB0", VA = "0x181CC1DB0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x1CC1E20", Offset = "0x1CC0C20", VA = "0x181CC1E20")]
			public static ICALIGFLGNM LCDANBPKPJD()
			{
				return default(ICALIGFLGNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct NNHHNHBFDJI : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct PADBEHKJGAC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* EIBGGJJDLGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly HGGDAGHLLHK.GEJLGLBEILG.FAJLBBDELGF KONNOIDOGFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly IFAEDNBIFMG LAKAALEJDAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::JMMBMFDPPCF<CCKGGMKEPJM> BMJINKLIJOB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int HJANCPDHNPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int HIOACLBEGPK;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x1CC4160", Offset = "0x1CC2F60", VA = "0x181CC4160")]
				public unsafe PADBEHKJGAC(Unity.Entities.Archetype* EIBGGJJDLGC, HGGDAGHLLHK.GEJLGLBEILG.FAJLBBDELGF KONNOIDOGFO, IFAEDNBIFMG LAKAALEJDAJ, global::JMMBMFDPPCF<CCKGGMKEPJM> BMJINKLIJOB, int HJANCPDHNPG, int HIOACLBEGPK = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x1CC41C0", Offset = "0x1CC2FC0", VA = "0x181CC41C0")]
				public PADBEHKJGAC(in PADBEHKJGAC CPLKBCGCHAN, int HIOACLBEGPK)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly PADBEHKJGAC[] PDGNCDHKFCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] NJCJHMAGMBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int LIEOBHNCLHK;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1CC3A00", Offset = "0x1CC2800", VA = "0x181CC3A00")]
			public NNHHNHBFDJI(PADBEHKJGAC[] PDGNCDHKFCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1CC39A0", Offset = "0x1CC27A0", VA = "0x181CC39A0", Slot = "4")]
			public void Invoke(int DJIEOHJNDEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1CC3320", Offset = "0x1CC2120", VA = "0x181CC3320")]
			private void BEGHPKEEAOH(in PADBEHKJGAC CPLKBCGCHAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1CC36D0", Offset = "0x1CC24D0", VA = "0x181CC36D0")]
			private static void DGGAEFNGCIK(in PADBEHKJGAC CPLKBCGCHAN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class MCFOPCDCNNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public HGGDAGHLLHK asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::JMMBMFDPPCF<CCKGGMKEPJM> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public MCFOPCDCNNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1CC28C0", Offset = "0x1CC16C0", VA = "0x181CC28C0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class KJAGOFOMOJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public HGGDAGHLLHK.GEJLGLBEILG.FAJLBBDELGF srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public MCFOPCDCNNN CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public KJAGOFOMOJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class HPMGPKGEGEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public KJAGOFOMOJP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public HPMGPKGEGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1CC1CA0", Offset = "0x1CC0AA0", VA = "0x181CC1CA0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly EKGLDANHPKF NCAKIFNFNNC;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly EKGLDANHPKF DLFOMHNACLE;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly EKGLDANHPKF IPGLEKOGMOH;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly EKGLDANHPKF LLBHGLPPKFD;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool KGGGMFOJLPG;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static HGGDAGHLLHK.GEJLGLBEILG.AKGBHBFBCNH CPCLAOBILKE;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8E00", Offset = "0x1CC7C00", VA = "0x181CC8E00")]
		private unsafe static bool FBADOBMJBBJ(Unity.Entities.Archetype* ICNAFELCIGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1CC89B0", Offset = "0x1CC77B0", VA = "0x181CC89B0")]
		internal unsafe static Unity.Entities.Archetype*[] DFLDHDGMEJG(ref Unity.Entities.EntityComponentStore FGCLICLNPJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1CCBB90", Offset = "0x1CCA990", VA = "0x181CCBB90")]
		public static void PLLBGNIGJPE(PLMMGPNIKJM DJCIICEJFGH, out ByteString KLGAKJLGGNF, out NativeArray<EntityRemapUtility.EntityRemapInfo> EGBMIILGDGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA7D0", Offset = "0x1CC95D0", VA = "0x181CCA7D0")]
		internal static void MGHHMFFAOKA(PLMMGPNIKJM DJCIICEJFGH, HGGDAGHLLHK HMAONMLHEGA, out NativeArray<EntityRemapUtility.EntityRemapInfo> EGBMIILGDGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8F10", Offset = "0x1CC7D10", VA = "0x181CC8F10")]
		private unsafe static UnsafeHashMap<ulong, CCHDHKDHMCO> FHMKOBLAOBI(Unity.Entities.Archetype*[] BBAKHHDCBNI)
		{
			return default(UnsafeHashMap<ulong, CCHDHKDHMCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA230", Offset = "0x1CC9030", VA = "0x181CCA230")]
		private static void LEBKLOLGLAC(HGGDAGHLLHK HMAONMLHEGA, UnsafeHashMap<ulong, CCHDHKDHMCO> EDLCFDHFIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1CC98F0", Offset = "0x1CC86F0", VA = "0x181CC98F0")]
		private unsafe static void HBLOJCHGKCF(HGGDAGHLLHK HMAONMLHEGA, Unity.Entities.Archetype*[] BBAKHHDCBNI, UnsafeHashMap<ulong, CCHDHKDHMCO> EDLCFDHFIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1CC91A0", Offset = "0x1CC7FA0", VA = "0x181CC91A0")]
		private unsafe static int FICJBIAFJKC(Unity.Entities.Archetype*[] BBAKHHDCBNI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1CCAF00", Offset = "0x1CC9D00", VA = "0x181CCAF00")]
		private unsafe static void MKDKBMIHBLH(HGGDAGHLLHK HMAONMLHEGA, Unity.Entities.Archetype*[] BBAKHHDCBNI, global::JMMBMFDPPCF<CCKGGMKEPJM> BMJINKLIJOB, NativeArray<EntityRemapUtility.EntityRemapInfo> EGBMIILGDGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8B90", Offset = "0x1CC7990", VA = "0x181CC8B90")]
		private static NativeArray<int> EKFGMINAJDG(HGGDAGHLLHK HMAONMLHEGA)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB550", Offset = "0x1CCA350", VA = "0x181CCB550")]
		private static Memory<EntityArchetype> PBJKJKEDIOB(HGGDAGHLLHK HMAONMLHEGA, NativeArray<int> CBKHHLNLKPG, EntityManager ECFOMHOIDDI, out int ELDMPGDIIEF, out int IJBHGCFHDMI)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1CC9C20", Offset = "0x1CC8A20", VA = "0x181CC9C20")]
		private unsafe static void IFKMJHIBKKH(Unity.Entities.Chunk* BMHGJKJEMMM, ReadOnlySpan<byte> KLGAKJLGGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1CC81F0", Offset = "0x1CC6FF0", VA = "0x181CC81F0")]
		private static void CCALCMKFCJP(HGGDAGHLLHK HMAONMLHEGA, NativeArray<int> CBKHHLNLKPG, Span<EntityArchetype> BBAKHHDCBNI, EntityManager ECFOMHOIDDI, global::JMMBMFDPPCF<CCKGGMKEPJM> BMJINKLIJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8930", Offset = "0x1CC7730", VA = "0x181CC8930")]
		private unsafe static void CJEDGEELFDC(Unity.Entities.Chunk* LJKLLDMPOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA3E0", Offset = "0x1CC91E0", VA = "0x181CCA3E0")]
		private unsafe static void MBNAPHDGAPP(HGGDAGHLLHK.GEJLGLBEILG.FAJLBBDELGF EIBGGJJDLGC, int DBKIFCAMKPD, int DGOEEFECOHF, Unity.Entities.Chunk* BMHGJKJEMMM, HGGDAGHLLHK HMAONMLHEGA, NativeArray<int> CBKHHLNLKPG, global::JMMBMFDPPCF<CCKGGMKEPJM> BMJINKLIJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1CC9210", Offset = "0x1CC8010", VA = "0x181CC9210")]
		public static void GOIPDAKAIJB(PLMMGPNIKJM DJCIICEJFGH, in ByteString KLGAKJLGGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1CC92A0", Offset = "0x1CC80A0", VA = "0x181CC92A0")]
		public static void GOIPDAKAIJB(EntityManager ECFOMHOIDDI, global::JMMBMFDPPCF<CCKGGMKEPJM> BMJINKLIJOB, in ByteString KLGAKJLGGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1CC9F70", Offset = "0x1CC8D70", VA = "0x181CC9F70")]
		private static bool IIKGNNAAFPL(Type LAKBKKJKBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB8E0", Offset = "0x1CCA6E0", VA = "0x181CCB8E0")]
		private static void PCJBMHIDNLG(TypeManager.TypeInfo DPIIHPBGDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB3C0", Offset = "0x1CCA1C0", VA = "0x181CCB3C0")]
		private unsafe static int OHNHCEILAGI(Unity.Entities.Archetype*[] BBAKHHDCBNI, NativeArray<EntityRemapUtility.EntityRemapInfo> EGBMIILGDGL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA6F0", Offset = "0x1CC94F0", VA = "0x181CCA6F0")]
		private static int MGDMPDOKGLO(int EDBPGCEKEHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB320", Offset = "0x1CCA120", VA = "0x181CCB320")]
		private static ulong NFKNBDLDNGC(int EDBPGCEKEHE)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class NPOFADEMMLG
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1CC3B40", Offset = "0x1CC2940", VA = "0x181CC3B40")]
	private unsafe static Span<byte> CMNMEONIKJH(Unity.Entities.Chunk* LJKLLDMPOPK, int HJANCPDHNPG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x367C150", Offset = "0x367AF50", VA = "0x18367C150")]
	public unsafe static Span<T> EMDFHOMCGDM<T>(Unity.Entities.Chunk* LJKLLDMPOPK, int HJANCPDHNPG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x367C2D0", Offset = "0x367B0D0", VA = "0x18367C2D0")]
	public static Span<T> EMDFHOMCGDM<T>(this ref Unity.Entities.Chunk LJKLLDMPOPK, int HJANCPDHNPG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1CC40B0", Offset = "0x1CC2EB0", VA = "0x181CC40B0")]
	public unsafe static Span<Entity> ONEFLANDLBA(Unity.Entities.Chunk* LJKLLDMPOPK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1CC3CE0", Offset = "0x1CC2AE0", VA = "0x181CC3CE0")]
	public unsafe static void KJHAHNAAJMI(Unity.Entities.Chunk* LJKLLDMPOPK, int HJANCPDHNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1CC3F80", Offset = "0x1CC2D80", VA = "0x181CC3F80")]
	public static Entity LKAAGAFGMHF(this EntityQuery EFCFIFNMPEK)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : IFFEHGABMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1CCBEB0", Offset = "0x1CCACB0", VA = "0x181CCBEB0", Slot = "4")]
		public sealed override void EAJHEFOPBGE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
