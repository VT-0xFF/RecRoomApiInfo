using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.ComponentSystems;
using RecRoom.NoEngine.JetBrains.Annotations;
using RecRoom.ObjectModel.Entities;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB610", Offset = "0x8BDA210", VA = "0x188BDB610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class DZISONAGUEP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
	{
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9E70", Offset = "0x8BD8A70", VA = "0x188BD9E70")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface LWSBFPFNRUG : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TokenHandle TokenHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface EMEIUZINPNA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AVUDOSXTPHH(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BALGJVVSAKW(Entity a, object b, [Out] bool c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UHFQQNFOZCB(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IEnumerable<object> SMTWIRBAKRU(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MWCWNXASUQV<a, b> : YFFPBHVCUTT<b>, IDisposable where a : struct, LWSBFPFNRUG
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class GRULTQKNKQC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private List<(object token, b value)> EOIWMZUINOR;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int YDGZHCXKSNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x2C24800", Offset = "0x2C23400", VA = "0x182C24800")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5419DE0", Offset = "0x54189E0", VA = "0x185419DE0")]
			public bool MMADINXVYUO([Out] b a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5419A80", Offset = "0x5418680", VA = "0x185419A80")]
			public void Add(object token, b value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x541A0A0", Offset = "0x5418CA0", VA = "0x18541A0A0")]
			public bool Remove(object token)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x541A2B0", Offset = "0x5418EB0", VA = "0x18541A2B0")]
			public int STWOLSBOSLI(object a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x541A3D0", Offset = "0x5418FD0", VA = "0x18541A3D0")]
			public GRULTQKNKQC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Stack<GRULTQKNKQC> YTXMEGKVSML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ManagedObjectPool<TokenHandle, GRULTQKNKQC> SELYZABUFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private EntityManager VYWLGVNSDFD;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBCE0", Offset = "0x5EDA8E0", VA = "0x185EDBCE0")]
		public MWCWNXASUQV(EntityManager a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA9E0", Offset = "0x5ED95E0", VA = "0x185EDA9E0", Slot = "4")]
		public void AVUDOSXTPHH(Entity a, object b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EDADA0", Offset = "0x5ED99A0", VA = "0x185EDADA0", Slot = "5")]
		public bool BALGJVVSAKW(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB8A0", Offset = "0x5EDA4A0", VA = "0x185EDB8A0", Slot = "6")]
		public bool MMADINXVYUO(Entity a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB160", Offset = "0x5ED9D60", VA = "0x185EDB160", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBAA0", Offset = "0x5EDA6A0", VA = "0x185EDBAA0")]
		private void WFLJHWCJZFQ(GRULTQKNKQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB7F0", Offset = "0x5EDA3F0", VA = "0x185EDB7F0")]
		private bool LOCKNGIYIQU(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB180", Offset = "0x5ED9D80", VA = "0x185EDB180")]
		private void GCDMLAYZGCM(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBBE0", Offset = "0x5EDA7E0", VA = "0x185EDBBE0")]
		private bool ZYKTJLRQMRM(TokenHandle a, [Out] GRULTQKNKQC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB4E0", Offset = "0x5EDA0E0", VA = "0x185EDB4E0")]
		private GRULTQKNKQC IFUHVQUVUVA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface YFFPBHVCUTT<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AVUDOSXTPHH(Entity a, object b, a c);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BALGJVVSAKW(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MMADINXVYUO(Entity a, [Out] a b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TokenHandle : OVGDGFNFTIG, IEquatable<TokenHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly TokenHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x32F76D0", Offset = "0x32F62D0", VA = "0x1832F76D0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x32F76E0", Offset = "0x32F62E0", VA = "0x1832F76E0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BDBC50", Offset = "0x8BDA850", VA = "0x188BDBC50", Slot = "8")]
		public bool Equals(TokenHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BDBCA0", Offset = "0x8BDA8A0", VA = "0x188BDBCA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class DDZMTGXJIHK<a> : EMEIUZINPNA, IDisposable where a : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Entity, TokenHandle> DZEYQGGSKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Stack<HashSet<object>> YTXMEGKVSML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ManagedObjectPool<TokenHandle, HashSet<object>> SELYZABUFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EntityManager VYWLGVNSDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private EntityCommandBufferSystem MZMEVPLXHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x465AC10", Offset = "0x4659810", VA = "0x18465AC10")]
		public DDZMTGXJIHK(EntityManager a, EntityCommandBufferSystem b, Log c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4655060", Offset = "0x4653C60", VA = "0x184655060", Slot = "4")]
		public bool AVUDOSXTPHH(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4657270", Offset = "0x4655E70", VA = "0x184657270", Slot = "5")]
		public bool BALGJVVSAKW(Entity a, object b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x465A120", Offset = "0x4658D20", VA = "0x18465A120", Slot = "6")]
		public bool UHFQQNFOZCB(Entity a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4659F10", Offset = "0x4658B10", VA = "0x184659F10", Slot = "9")]
		public bool UHFQQNFOZCB(TokenHandle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4659AE0", Offset = "0x46586E0", VA = "0x184659AE0", Slot = "7")]
		public IEnumerable<object> SMTWIRBAKRU(Entity a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4659770", Offset = "0x4658370", VA = "0x184659770", Slot = "10")]
		public IEnumerable<object> SMTWIRBAKRU(TokenHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4658130", Offset = "0x4656D30", VA = "0x184658130", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x465A6A0", Offset = "0x46592A0", VA = "0x18465A6A0")]
		private void WFLJHWCJZFQ(HashSet<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4659500", Offset = "0x4658100", VA = "0x184659500")]
		private bool LOCKNGIYIQU(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4657A40", Offset = "0x4656640", VA = "0x184657A40")]
		private bool DPQDJPMWJLK(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4658840", Offset = "0x4657440", VA = "0x184658840")]
		private void IHPSWJWYJYD(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4658E50", Offset = "0x4657A50", VA = "0x184658E50")]
		private void JGSOEKDBWYG(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4657D90", Offset = "0x4656990", VA = "0x184657D90")]
		private void DYQCYHHNIID(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46582D0", Offset = "0x4656ED0", VA = "0x1846582D0")]
		private void GCDMLAYZGCM(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46592A0", Offset = "0x4657EA0", VA = "0x1846592A0")]
		private bool JVAIUZUXVCF(TokenHandle a, [Out] HashSet<object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4658560", Offset = "0x4657160", VA = "0x184658560")]
		private HashSet<object> IFUHVQUVUVA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class NTWQKQQRNVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public (bool filter, string file, NativeArray<Entity> entities, EntityManager entityManager) IAXJUMIBIDG;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8BD9A80", Offset = "0x8BD8680", VA = "0x188BD9A80")]
			internal string OFSZRPSTNCI(Entity a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAFD0", Offset = "0x8BD9BD0", VA = "0x188BDAFD0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PRPLUDEJNRT(this Log a, NativeArray<Entity> b, [Optional][CallerFilePath] string file)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAFA0", Offset = "0x8BD9BA0", VA = "0x188BDAFA0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PRPLUDEJNRT(this Log a, string b, NativeArray<Entity> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAD00", Offset = "0x8BD9900", VA = "0x188BDAD00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PRPLUDEJNRT(this Log a, string b, NativeArray<Entity> c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAEA0", Offset = "0x8BD9AA0", VA = "0x188BDAEA0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PRPLUDEJNRT(this Log a, string b, EntityQuery c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BDAB30", Offset = "0x8BD9730", VA = "0x188BDAB30")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void COSDZKBQION(this Log a, NativeArray<Entity> b, EntityManager c, [Optional][CallerFilePath] string file)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA960", Offset = "0x8BD9560", VA = "0x188BDA960")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void COSDZKBQION(this Log a, string b, NativeArray<Entity> c, EntityManager d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB3D0", Offset = "0x8BD9FD0", VA = "0x188BDB3D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void VLAESVSTWIL(this Log a, NativeArray<Entity> b, NativeArray<Entity> c, [Optional][CallerFilePath] string file)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB200", Offset = "0x8BD9E00", VA = "0x188BDB200")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void VLAESVSTWIL(this Log a, string b, NativeArray<Entity> c, NativeArray<Entity> d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1F40", Offset = "0x3DC0B40", VA = "0x183DC1F40")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void QEIVUURHEBI<T>(this Log a, NativeArray<Entity> b, NativeArray<T> c, [Optional][CallerFilePath] string file) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1900", Offset = "0x3DC0500", VA = "0x183DC1900")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void QEIVUURHEBI<T>(this Log a, string b, NativeArray<Entity> c, NativeArray<T> d) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1990", Offset = "0x3DC0590", VA = "0x183DC1990")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void QEIVUURHEBI<a>(this Log a, string b, NativeArray<Entity> c, NativeArray<a> d, bool e) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1880", Offset = "0x3DC0480", VA = "0x183DC1880")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PDZKFDKZOFO<T>(this Log a, NativeList<T> b, [Optional][CallerFilePath] string file) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1310", Offset = "0x3DBFF10", VA = "0x183DC1310")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PDZKFDKZOFO<T>(this Log a, NativeArray<T> b, [Optional][CallerFilePath] string file) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1380", Offset = "0x3DBFF80", VA = "0x183DC1380")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void PDZKFDKZOFO<T>(this Log a, string b, NativeArray<T> c, bool d) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB030", Offset = "0x8BD9C30", VA = "0x188BDB030")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void RVAMSZRNBQG(this Log a, EntityQuery b, [Optional][CallerFilePath] string file)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB000", Offset = "0x8BD9C00", VA = "0x188BDB000")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void RVAMSZRNBQG(this Log a, string b, EntityQuery c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB060", Offset = "0x8BD9C60", VA = "0x188BDB060")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void RVAMSZRNBQG(this Log a, string b, EntityQuery c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC12B0", Offset = "0x3DBFEB0", VA = "0x183DC12B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void HFCGGRFINLC<T>(this Log a, string b, NativeList<T> c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC10B0", Offset = "0x3DBFCB0", VA = "0x183DC10B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void HFCGGRFINLC<T>(this Log a, string b, NativeList<T> c, bool d) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1310", Offset = "0x3DBFF10", VA = "0x183DC1310")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void YCAVZFQVGMV<b>(this Log a, NativeArray<b> b, [Optional][CallerFilePath] string file) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1FD0", Offset = "0x3DC0BD0", VA = "0x183DC1FD0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void YCAVZFQVGMV<c>(this Log a, string b, NativeArray<c> c) where c : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1380", Offset = "0x3DBFF80", VA = "0x183DC1380")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void YCAVZFQVGMV<d>(this Log a, string b, NativeArray<d> c, bool d) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1FD0", Offset = "0x3DC0BD0", VA = "0x183DC1FD0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void XDUOTKVNIDO<TKey, TValue>(this Log a, string b, NativeParallelHashMap<TKey, TValue> c) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1380", Offset = "0x3DBFF80", VA = "0x183DC1380")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void XDUOTKVNIDO<TKey, TValue>(this Log a, string b, NativeParallelHashMap<TKey, TValue> c, bool d) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1310", Offset = "0x3DBFF10", VA = "0x183DC1310")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void XDUOTKVNIDO<TKey, TValue>(this Log a, UnsafeParallelHashMap<TKey, TValue> b, [Optional][CallerFilePath] string file) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1380", Offset = "0x3DBFF80", VA = "0x183DC1380")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void XDUOTKVNIDO<TKey, TValue>(this Log a, string b, UnsafeParallelHashMap<TKey, TValue> c, bool d) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB5A0", Offset = "0x8BDA1A0", VA = "0x188BDB5A0")]
		private static string WSLXOGUNDTC(string a, bool b)
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel.Mappers
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Float3GetX : VHSZZXQZPRQ<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9E90", Offset = "0x8BD8A90", VA = "0x188BD9E90")]
		public float FDTRPIIGCIZ([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9E90", Offset = "0x8BD8A90", VA = "0x188BD9E90", Slot = "4")]
		private float MHMDLTGQJAH([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Float3GetY : VHSZZXQZPRQ<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9EA0", Offset = "0x8BD8AA0", VA = "0x188BD9EA0")]
		public float FDTRPIIGCIZ([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9EA0", Offset = "0x8BD8AA0", VA = "0x188BD9EA0", Slot = "4")]
		private float MHMDLTGQJAH([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct Float3GetZ : VHSZZXQZPRQ<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x110B2D0", Offset = "0x1109ED0", VA = "0x18110B2D0")]
		public float FDTRPIIGCIZ([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x110B2D0", Offset = "0x1109ED0", VA = "0x18110B2D0", Slot = "4")]
		private float MHMDLTGQJAH([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Int3GetX : VHSZZXQZPRQ<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1542A70", Offset = "0x1541670", VA = "0x181542A70")]
		public int FDTRPIIGCIZ([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1542A70", Offset = "0x1541670", VA = "0x181542A70", Slot = "4")]
		private int NJOWFMWBBHW([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Int3GetY : VHSZZXQZPRQ<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x14D9CF0", Offset = "0x14D88F0", VA = "0x1814D9CF0")]
		public int FDTRPIIGCIZ([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x14D9CF0", Offset = "0x14D88F0", VA = "0x1814D9CF0", Slot = "4")]
		private int NJOWFMWBBHW([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct Int3GetZ : VHSZZXQZPRQ<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1047AF0", Offset = "0x10466F0", VA = "0x181047AF0")]
		public int FDTRPIIGCIZ([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1047AF0", Offset = "0x10466F0", VA = "0x181047AF0", Slot = "4")]
		private int NJOWFMWBBHW([In] int3 value)
		{
			return default(int);
		}
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class RegisterComponentSystem : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3087E60", Offset = "0x3086A60", VA = "0x183087E60")]
		public RegisterComponentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class LHHEXZWIHSB : SystemBase, XIKXBUEXYSC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComponentSystemGroup? MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string? QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private string XVWNDFVXHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8BDA490", Offset = "0x8BD9090", VA = "0x188BDA490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA5F0", Offset = "0x8BD91F0", VA = "0x188BDA5F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3CADE70", Offset = "0x3CACA70", VA = "0x183CADE70")]
		public void MRXVTTCZSVX<a>() where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD6E0", Offset = "0x3CAC2E0", VA = "0x183CAD6E0")]
		public void FCSVDKJUGRW<b>() where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA5A0", Offset = "0x8BD91A0", VA = "0x188BDA5A0")]
		public JobHandle SYRIQLDOOPA(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3CADDE0", Offset = "0x3CAC9E0", VA = "0x183CADDE0")]
		public JobHandle LAXESHAFMLF<d>() where d : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA440", Offset = "0x8BD9040", VA = "0x188BDA440")]
		public JobHandle LAXESHAFMLF(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE110", Offset = "0x3CACD10", VA = "0x183CAE110")]
		public void PDSZLBUMFWZ<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3CADF90", Offset = "0x3CACB90", VA = "0x183CADF90")]
		public JobHandle PDSZLBUMFWZ<f>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA4D0", Offset = "0x8BD90D0", VA = "0x188BDA4D0")]
		public JobHandle PDSZLBUMFWZ(ReadOnlySpan<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD8A0", Offset = "0x3CAC4A0", VA = "0x183CAD8A0")]
		public void KSXVZWLZQES<g>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD990", Offset = "0x3CAC590", VA = "0x183CAD990")]
		public JobHandle KSXVZWLZQES<h>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA3D0", Offset = "0x8BD8FD0", VA = "0x188BDA3D0")]
		public JobHandle KSXVZWLZQES(Span<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD810", Offset = "0x3CAC410", VA = "0x183CAD810")]
		public ComponentDataFromEntity GQPOLRBNSMG<i>(bool a = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA2B0", Offset = "0x8BD8EB0", VA = "0x188BDA2B0")]
		public ComponentDataFromEntity GQPOLRBNSMG(int a, bool b = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD570", Offset = "0x3CAC170", VA = "0x183CAD570")]
		public SharedComponentIndexFromEntity<j> BTPJFUYSBSA<j>() where j : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA540", Offset = "0x8BD9140", VA = "0x188BDA540")]
		[GenerateTestsForBurstCompatibility]
		public ComponentTypeHandle RAANATRSRKE(ComponentType a)
		{
			return default(ComponentTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA6C0", Offset = "0x8BD92C0", VA = "0x188BDA6C0")]
		public EntityExistenceLookupByEntity XKGHFBXEFNS()
		{
			return default(EntityExistenceLookupByEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA6B0", Offset = "0x8BD92B0", VA = "0x188BDA6B0", Slot = "10")]
		public sealed override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE520", Offset = "0x3CAD120", VA = "0x183CAE520")]
		public bool XWTVUEAHKAS<k>()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		[Preserve]
		protected sealed override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3087E60", Offset = "0x3086A60", VA = "0x183087E60")]
		[Preserve]
		protected LHHEXZWIHSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class TUIDLKCFADE : LHHEXZWIHSB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BDBC20", Offset = "0x8BDA820", VA = "0x188BDBC20", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3087E60", Offset = "0x3086A60", VA = "0x183087E60")]
		[Preserve]
		protected TUIDLKCFADE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class ILBFUSCEXID
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class IOIZXCYQQWU : EntityCommandBufferSystem, XIKXBUEXYSC
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual Log NPHEYIXDMFH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xB31CA0", Offset = "0xB308A0", VA = "0x180B31CA0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(Log);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB9A3D0", Offset = "0xB98FD0", VA = "0x180B9A3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ComponentSystemGroup? MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string? QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string XVWNDFVXHMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8BDA070", Offset = "0x8BD8C70", VA = "0x188BDA070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA180", Offset = "0x8BD8D80", VA = "0x188BDA180")]
		public IOIZXCYQQWU(Log a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA0C0", Offset = "0x8BD8CC0", VA = "0x188BDA0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA0B0", Offset = "0x8BD8CB0", VA = "0x188BDA0B0", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void YTBXBXEJHFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface VHSZZXQZPRQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b FDTRPIIGCIZ([In] a value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface IWDMCACNDKE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HBXZJJOJJDE(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	internal struct AddComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public ComponentTypeSet componentTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9A00", Offset = "0x8BD8600", VA = "0x188BD9A00", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	internal struct DestroyEntityECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9DD0", Offset = "0x8BD89D0", VA = "0x188BD9DD0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	internal struct RemoveComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public ComponentType componentType;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BDBBA0", Offset = "0x8BDA7A0", VA = "0x188BDBBA0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	internal struct SetComponentECB<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6522E10", Offset = "0x6521A10", VA = "0x186522E10", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal struct SetSharedComponentArrayECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65240B0", Offset = "0x6522CB0", VA = "0x1865240B0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal struct SetSharedComponentECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Unity.Collections.ReadOnly]
		public T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6524260", Offset = "0x6522E60", VA = "0x186524260", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[BurstCompile]
	internal struct MapArrayJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, VHSZZXQZPRQ<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[WriteOnly]
		public NativeArray<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F17690", Offset = "0x5F16290", VA = "0x185F17690", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[BurstCompile]
	internal struct MapEntityToComponentDataArrayJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity srcDataFromEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[WriteOnly]
		public NativeArray<byte> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int typeSize;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA6F0", Offset = "0x8BD92F0", VA = "0x188BDA6F0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[BurstCompile]
	internal struct MapEntityToComponentDataListJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> dstDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[WriteOnly]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5F17A60", Offset = "0x5F16660", VA = "0x185F17A60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[BurstCompile]
	internal struct MapListJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, VHSZZXQZPRQ<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[WriteOnly]
		public NativeList<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F24EA0", Offset = "0x5F23AA0", VA = "0x185F24EA0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[BurstCompile]
	internal struct ReduceAllHaveComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x647E480", Offset = "0x647D080", VA = "0x18647E480", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal struct ReduceAnyHasComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x647E600", Offset = "0x647D200", VA = "0x18647E600", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal struct ReduceDistinctJob<T> : IJob where T : struct, IEquatable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeParallelHashSet<T> set;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x647E8F0", Offset = "0x647D4F0", VA = "0x18647E8F0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[BurstCompile]
	internal struct ReduceDistinctSelectJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : VHSZZXQZPRQ<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeList<TFrom> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeParallelHashSet<TTo> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x647E9B0", Offset = "0x647D5B0", VA = "0x18647E9B0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[BurstCompile]
	internal struct ReduceEntitiesPredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, IWDMCACNDKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntityArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<Entity> dstEntityList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x647EE70", Offset = "0x647DA70", VA = "0x18647EE70", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[BurstCompile]
	internal struct ReducePredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, IWDMCACNDKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x647F780", Offset = "0x647E380", VA = "0x18647F780", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[BurstCompile]
	internal struct ReduceWithComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BDBA70", Offset = "0x8BDA670", VA = "0x188BDBA70", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[BurstCompile]
	internal struct ReduceWithoutComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BDBB00", Offset = "0x8BDA700", VA = "0x188BDBB00", Slot = "4")]
		[IgnoreWarning(1371)]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class RLNWLQBHWRB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class VLFFFQTWTFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x41997A0", Offset = "0x41983A0", VA = "0x1841997A0")]
		public static bool ACPMNIDUHTE<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class KSCYUYRLBZS
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class LKBOFJWMHKH<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LKBOFJWMHKH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class WTFRSPBGSXA<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WTFRSPBGSXA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly List<Func<JobHandle, JobHandle>> ZHMNUWINGGV;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA230", Offset = "0x8BD8E30", VA = "0x188BDA230")]
		public KSCYUYRLBZS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class NHQAPPFBHEW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class AFRJBSDGWLL
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006E")]
				internal Array<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			internal NativeArray<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct List<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000071")]
				internal List<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			internal NativeList<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				internal ArrayAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			internal NativeArrayAsync<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				internal ListAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			internal NativeListAsync<TFrom> src;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class YHBTRCNSVTP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class RRZJHBRIJWX
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FB5020", Offset = "0x3FB3C20", VA = "0x183FB5020")]
		public static NativeList<T> JMMGIJKLKIN<T>(this NativeArray<T> a, Allocator b = Allocator.TempJob) where T : struct, IEquatable<T>
		{
			return default(NativeList<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class SZJSHOFZJPH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class CEZJYDNJPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x39AA080", Offset = "0x39A8C80", VA = "0x1839AA080")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x39A9730", Offset = "0x39A8330", VA = "0x1839A9730")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArrayAsync<Entity> entities, NativeArrayAsync<T> data, [Optional] JobHandle dependsOn) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x39A9940", Offset = "0x39A8540", VA = "0x1839A9940")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9B00", Offset = "0x8BD8700", VA = "0x188BD9B00")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9C60", Offset = "0x8BD8860", VA = "0x188BD9C60")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, EntityCommandBuffer ecb, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class OBLKRJBIXKM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class OUWKSVWEVHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB690", Offset = "0x8BDA290", VA = "0x188BDB690")]
		[MustUseReturnValue]
		public static JobHandle YSWQMUVFSBQ(this EntityCommandBufferSystem a, NativeList<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB810", Offset = "0x8BDA410", VA = "0x188BDB810")]
		[MustUseReturnValue]
		public static JobHandle YSWQMUVFSBQ(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class NDIWYXQTWGU
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3DB2AB0", Offset = "0x3DB16B0", VA = "0x183DB2AB0")]
		public static void ULOXIQNXTTS<a>(this EntityCommandBufferSystem a, EntityQuery b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DB28F0", Offset = "0x3DB14F0", VA = "0x183DB28F0")]
		[MustUseReturnValue]
		public static JobHandle MFTRIRMWSYA<e>(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BDA7F0", Offset = "0x8BD93F0", VA = "0x188BDA7F0")]
		[MustUseReturnValue]
		public static JobHandle MFTRIRMWSYA(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, ComponentType c, [Optional] JobHandle d)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class IJXYLOFPWYK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5960", Offset = "0x3BF4560", VA = "0x183BF5960")]
		[MustUseReturnValue]
		public static JobHandle EJVGIMMFAHQ<T>(this EntityCommandBufferSystem a, NativeArray<Entity> b, NativeArray<T> c, JobHandle d) where T : struct, IComponentData
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class EQEIAUXGYVJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class BEPJUDSMGUY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class HYHMCSICNXY
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8A50", Offset = "0x3BD7650", VA = "0x183BD8A50")]
		public static NativeArray<a> YCPHCVXGWOX<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where a : struct, IComponentData
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8BF0", Offset = "0x3BD77F0", VA = "0x183BD8BF0")]
		public static NativeArray<b> YCPHCVXGWOX<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where b : struct, IComponentData
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BD9EB0", Offset = "0x8BD8AB0", VA = "0x188BD9EB0")]
		public static NativeArray<Entity> IMMYCETZHWQ(this NativeArray<Entity> a, EntityManager b, ComponentType c, Allocator d = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3BD86D0", Offset = "0x3BD72D0", VA = "0x183BD86D0")]
		public static NativeArray<T> METBAIOZFMA<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class IQYOQLNCJTF
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public Array<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public NativeArray<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400007D")]
				public ArrayAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public NativeArrayAsync<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				public ListAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public NativeListAsync<TFrom> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class NIWOFYZQCHF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class ICKVPANRXNJ
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private struct RemapEntitiesAction : VHSZZXQZPRQ<Entity, Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			[Unity.Collections.ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8BDBB90", Offset = "0x8BDA790", VA = "0x188BDBB90")]
			[GenerateTestsForBurstCompatibility]
			public Entity FDTRPIIGCIZ([In] Entity value)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BDBB90", Offset = "0x8BDA790", VA = "0x188BDBB90", Slot = "4")]
			private Entity BPNWBGBVERI([In] Entity value)
			{
				return default(Entity);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class VCMVDXLXVQA
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private struct Comparer<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x45CEC80", Offset = "0x45CD880", VA = "0x1845CEC80", Slot = "4")]
			public int Compare((TKey, TValue) x, (TKey, TValue) y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4193750", Offset = "0x4192350", VA = "0x184193750")]
		public static void Sort<TKey, TValue>(NativeList<TKey> keys, NativeList<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4193570", Offset = "0x4192170", VA = "0x184193570")]
		public static void Sort<TKey, TValue>(NativeArray<TKey> keys, NativeArray<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4194E40", Offset = "0x4193A40", VA = "0x184194E40")]
		public static void Sort<TKey, TValue, U>(NativeArray<TKey> keys, NativeArray<TValue> values, U comparer) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class ROMWYYADFYG
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public NativeArray<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public NativeList<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public NativeArrayAsync<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public NativeArrayAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class ZDEPNXMNWDK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class TVOEWUJWWSO
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public NativeList<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public NativeArrayAsync<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct ListAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public NativeListAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class FEBJKUDUBUE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class OBQLRNPENLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9BA0", Offset = "0x3DF87A0", VA = "0x183DF9BA0")]
		public static NativeList<Entity> GOKWRDEUXPS<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9740", Offset = "0x3DF8340", VA = "0x183DF9740")]
		public static NativeList<Entity> GOKWRDEUXPS<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class GVVLLUMTHTY
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8050", Offset = "0x3BC6C50", VA = "0x183BC8050")]
		public static NativeList<Entity> KJYPZMDONPU<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class VSBXBJVFSQP
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public readonly struct EnumerateHelper<TSrc> where TSrc : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public readonly struct SelectTypeEnumerateHelper<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public readonly struct SelectedTypeEnumerateHelper<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, VHSZZXQZPRQ<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public struct SelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, VHSZZXQZPRQ<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private readonly NativeArray<TSrc> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private TSelector selector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct GroupedSelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, VHSZZXQZPRQ<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private SelectedTypeEnumerator<TSrc, TValue, TSelector> enumerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private TValue startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int startIndex;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class FMEORHNBMYE
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public struct GroupedEnumerator<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private T currValue;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RecRoom.Foundation.Collections.Range DAWVWURNTLV
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x5465660", Offset = "0x5464260", VA = "0x185465660")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public T JRYNLQZQJXJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public (T, RecRoom.Foundation.Collections.Range) EZFWAAOVWWO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x54646C0", Offset = "0x54632C0", VA = "0x1854646C0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5465670", Offset = "0x5464270", VA = "0x185465670")]
			public GroupedEnumerator(NativeArray<T> array)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4634BF0", Offset = "0x46337F0", VA = "0x184634BF0")]
			public GroupedEnumerator<T> GetEnumerator()
			{
				return default(GroupedEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5465270", Offset = "0x5463E70", VA = "0x185465270")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x40B0A80", Offset = "0x40AF680", VA = "0x1840B0A80")]
			public GroupedWithComparerEnumerator<T, a> XEFAFNSKNPS<a>([Optional] a a) where a : struct, IEqualityComparer<T>
			{
				return default(GroupedWithComparerEnumerator<T, a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct GroupedWithComparerEnumerator<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private T currValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TComparer comparer;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public RecRoom.Foundation.Collections.Range DAWVWURNTLV
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x5465660", Offset = "0x5464260", VA = "0x185465660")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public T JRYNLQZQJXJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public (T value, RecRoom.Foundation.Collections.Range range) EZFWAAOVWWO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x5465D80", Offset = "0x5464980", VA = "0x185465D80")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x5466A70", Offset = "0x5465670", VA = "0x185466A70")]
			public GroupedWithComparerEnumerator(NativeArray<T> array, TComparer comparer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x3BA5AE0", Offset = "0x3BA46E0", VA = "0x183BA5AE0")]
			public GroupedWithComparerEnumerator<T, TComparer> GetEnumerator()
			{
				return default(GroupedWithComparerEnumerator<T, TComparer>);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x54664C0", Offset = "0x54650C0", VA = "0x1854664C0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0FA0", Offset = "0x3B9FBA0", VA = "0x183BA0FA0")]
		public static GroupedEnumerator<T> Group<T>(this NativeArray<T> array) where T : struct
		{
			return default(GroupedEnumerator<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public struct ProtobufMessageListDeserializer<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class PKZVDUZDOZY : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private (int index, Protobuf element) DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public ProtobufMessageListDeserializer<Protobuf> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int NAMOISTICOB;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private (int, Protobuf) TFPPJGOFLYF
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x53C2B30", Offset = "0x53C1730", VA = "0x1853C2B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default((int, Protobuf));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x53C2BE0", Offset = "0x53C17E0", VA = "0x1853C2BE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x448DFC0", Offset = "0x448CBC0", VA = "0x18448DFC0")]
			[DebuggerHidden]
			public PKZVDUZDOZY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6181FD0", Offset = "0x6180BD0", VA = "0x186181FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Action<Protobuf> resetToDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly Protobuf element;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x61FE020", Offset = "0x61FCC20", VA = "0x1861FE020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61FDDD0", Offset = "0x61FC9D0", VA = "0x1861FDDD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61FDE70", Offset = "0x61FCA70", VA = "0x1861FDE70", Slot = "4")]
		[IteratorStateMachine(typeof(ProtobufMessageListDeserializer<>.PKZVDUZDOZY))]
		public IEnumerator<(int, Protobuf)> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61FDFD0", Offset = "0x61FCBD0", VA = "0x1861FDFD0", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct ProtobufMessageListSerializer<Protobuf> : IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Protobuf element;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61FE060", Offset = "0x61FCC60", VA = "0x1861FE060", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct ProtobufRawListDeserializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB910", Offset = "0x8BDA510", VA = "0x188BDB910", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct ProtobufRawListSerializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BDB950", Offset = "0x8BDA550", VA = "0x188BDB950", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class FQQKZKZIYNW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public static class PYCVTPPVBUF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Flags]
	public enum RRWorldFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Live = 1,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Editor = 3,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Main = 5,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Simulation = 9,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Conversion = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Staging = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Shadow = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Loading = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Saving = 0x100
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal static class OWIOYKKNFXE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[BurstCompile]
internal class WILSNZREXMT
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2280273744
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC2D0", Offset = "0x8BDAED0", VA = "0x188BDC2D0")]
	public static void TGIQTAWGCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC2C0", Offset = "0x8BDAEC0", VA = "0x188BDC2C0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
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
