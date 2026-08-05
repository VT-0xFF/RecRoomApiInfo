using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4EC0", Offset = "0x7AC42C0", VA = "0x187AC4EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KBAJCHADAOJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5BD0", Offset = "0x1FE4FD0", VA = "0x181FE5BD0")]
	public KBAJCHADAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GDMHIEJBDAJ, FPLHDPGGOJE, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MKLCJOILBMP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6490", Offset = "0x7AC5890", VA = "0x187AC6490")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6450", Offset = "0x7AC5850", VA = "0x187AC6450")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AC64D0", Offset = "0x7AC58D0", VA = "0x187AC64D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6680", Offset = "0x7AC5A80", VA = "0x187AC6680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AC65F0", Offset = "0x7AC59F0", VA = "0x187AC65F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEA4540", Offset = "0xEA3940", VA = "0x180EA4540")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCF3E70", Offset = "0xCF3270", VA = "0x180CF3E70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6410", Offset = "0x7AC5810", VA = "0x187AC6410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6560", Offset = "0x7AC5960", VA = "0x187AC6560")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5EB0", Offset = "0x7AC52B0", VA = "0x187AC5EB0")]
	public void CopyBounds(SavedExtents DMMBOHMLHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6360", Offset = "0x7AC5760", VA = "0x187AC6360")]
	public void SetLocalSpaceBounds(Bounds NMDGKLAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x138F660", Offset = "0x138EA60", VA = "0x18138F660")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6350", Offset = "0x7AC5750", VA = "0x187AC6350")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5EE0", Offset = "0x7AC52E0", VA = "0x187AC5EE0")]
	private void EHAEDIFGHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6150", Offset = "0x7AC5550", VA = "0x187AC6150")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5840", Offset = "0x7AC4C40", VA = "0x187AC5840")]
	public static void CalculateLocalBoundsFor(GameObject GMFIIANHHCH, [Out] Bounds NMDGKLAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6090", Offset = "0x7AC5490", VA = "0x187AC6090")]
	private static void MJONGBPJKEC(Bounds MDCPFJBHOAB, Color NEIELBLPLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6380", Offset = "0x7AC5780", VA = "0x187AC6380")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xED3D50", Offset = "0xED3150", VA = "0x180ED3D50")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x56DF960", Offset = "0x56DED60", VA = "0x1856DF960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public virtual void LEDAPMBHPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[KBAJCHADAOJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x56DF490", Offset = "0x56DE890", VA = "0x1856DF490", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x56DDF70", Offset = "0x56DD370", VA = "0x1856DDF70", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x56DF870", Offset = "0x56DEC70", VA = "0x1856DF870")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GIOLDNMDIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GIOLDNMDIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x48BDFE0", Offset = "0x48BD3E0", VA = "0x1848BDFE0")]
		internal int IPALECOLIBC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[KBAJCHADAOJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x43C2F30", Offset = "0x43C2330", VA = "0x1843C2F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43C2F90", Offset = "0x43C2390", VA = "0x1843C2F90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43C2E00", Offset = "0x43C2200", VA = "0x1843C2E00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey IICGAABOENK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43C2EC0", Offset = "0x43C22C0", VA = "0x1843C2EC0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x43C2CA0", Offset = "0x43C20A0", VA = "0x1843C2CA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43C2920", Offset = "0x43C1D20", VA = "0x1843C2920", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43C1C90", Offset = "0x43C1090", VA = "0x1843C1C90", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43C1BB0", Offset = "0x43C0FB0", VA = "0x1843C1BB0", Slot = "14")]
	protected virtual string EMOPFMAIKAE(TKeyVal KFBKMJEPDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43C1AF0", Offset = "0x43C0EF0", VA = "0x1843C1AF0", Slot = "4")]
	public bool ContainsKey(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43C2B10", Offset = "0x43C1F10", VA = "0x1843C2B10", Slot = "5")]
	public bool TryGetValue(TKey IICGAABOENK, [Out] TVal OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43C1BE0", Offset = "0x43C0FE0", VA = "0x1843C1BE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43C1BE0", Offset = "0x43C0FE0", VA = "0x1843C1BE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x43C2B70", Offset = "0x43C1F70", VA = "0x1843C2B70")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x434E6A0", Offset = "0x434DAA0", VA = "0x18434E6A0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[KBAJCHADAOJ]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x56E1400", Offset = "0x56E0800", VA = "0x1856E1400")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x56E0BF0", Offset = "0x56DFFF0", VA = "0x1856E0BF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x56E0130", Offset = "0x56DF530", VA = "0x1856E0130", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class OHNEEKLEHHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LEPJMNGOAPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T APFNDOMNAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float IJABIMOAFHL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int BLKGPGPGEJL = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float LBGAIFAADHO = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly LEPJMNGOAPL[] IMLJIFPAFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int HIHLFNOODLE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float COCLJHGHIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBD9050", Offset = "0xBD8450", VA = "0x180BD9050")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC3CE40", Offset = "0xC3C240", VA = "0x180C3CE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T MEHELIKBLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5344380", Offset = "0x5343780", VA = "0x185344380")]
	protected OHNEEKLEHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x53442E0", Offset = "0x53436E0", VA = "0x1853442E0")]
	protected OHNEEKLEHHF(int LLBNOFGPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x53441B0", Offset = "0x53435B0", VA = "0x1853441B0")]
	public void FGAAHPGCDNG(float ILKAOEMIOFJ, T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DPDHOKEHPME(float IDPAAPODFEL, float LJLKGMEJNBN, [Out] T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PABMNKBNHAM(float IDPAAPODFEL, float LJLKGMEJNBN, [Out] T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5344020", Offset = "0x5343420", VA = "0x185344020")]
	public void ENAIKFMHAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JGICDBAGEJE : OHNEEKLEHHF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3C30", Offset = "0x7AC3030", VA = "0x187AC3C30", Slot = "4")]
	public override bool DPDHOKEHPME(float IDPAAPODFEL, float LJLKGMEJNBN, [Out] Vector3 OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3D90", Offset = "0x7AC3190", VA = "0x187AC3D90", Slot = "5")]
	public override bool PABMNKBNHAM(float IDPAAPODFEL, float LJLKGMEJNBN, [Out] Vector3 OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3ED0", Offset = "0x7AC32D0", VA = "0x187AC3ED0")]
	public JGICDBAGEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GNAGFOPNPMO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36C5C10", Offset = "0x36C5010", VA = "0x1836C5C10")]
	public static PAEJJKIMEGI<T1, T2> BPKMLDCMEGB<T1, T2>(T1 BEPLLKIJLLI, T2 KPIIHHGKAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36C5CB0", Offset = "0x36C50B0", VA = "0x1836C5CB0")]
	public static DIAEMGCDJKA<T1, T2, T3> BPKMLDCMEGB<T1, T2, T3>(T1 BEPLLKIJLLI, T2 KPIIHHGKAKD, T3 EDGANIKDMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5142410", Offset = "0x5141810", VA = "0x185142410")]
	internal static int IPNAPNHLEEJ(int IFHOIDFCMKN, int IFGGJENMDME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6CD4F50", Offset = "0x6CD4350", VA = "0x186CD4F50")]
	internal static int IPNAPNHLEEJ(int IFHOIDFCMKN, int IFGGJENMDME, int FAEMBGKJPON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PAEJJKIMEGI<T1, T2> : IComparable<PAEJJKIMEGI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 LJJCJIEDILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 JNFPALOEMOB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x542C460", Offset = "0x542B860", VA = "0x18542C460")]
	public PAEJJKIMEGI(T1 BEPLLKIJLLI, T2 KPIIHHGKAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x542A990", Offset = "0x5429D90", VA = "0x18542A990", Slot = "4")]
	public int CompareTo(PAEJJKIMEGI<T1, T2> DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x542B4A0", Offset = "0x542A8A0", VA = "0x18542B4A0", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x542B860", Offset = "0x542AC60", VA = "0x18542B860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x542BEE0", Offset = "0x542B2E0", VA = "0x18542BEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DIAEMGCDJKA<T1, T2, T3> : IComparable<DIAEMGCDJKA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 LJJCJIEDILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 JNFPALOEMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 BDPMAFGGAGI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6897B40", Offset = "0x6896F40", VA = "0x186897B40")]
	public DIAEMGCDJKA(T1 BEPLLKIJLLI, T2 KPIIHHGKAKD, T3 EDGANIKDMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68971A0", Offset = "0x68965A0", VA = "0x1868971A0", Slot = "4")]
	public int CompareTo(DIAEMGCDJKA<T1, T2, T3> DMMBOHMLHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6897580", Offset = "0x6896980", VA = "0x186897580", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6897740", Offset = "0x6896B40", VA = "0x186897740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6897980", Offset = "0x6896D80", VA = "0x186897980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve OIALCHODHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T IODMDAMDGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x120A900", Offset = "0x1209D00", VA = "0x18120A900")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OONFOHBECAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBD93B0", Offset = "0xBD87B0", VA = "0x180BD93B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF5E0", Offset = "0x2AAE9E0", VA = "0x182AAF5E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF3C0", Offset = "0x2AAE7C0", VA = "0x182AAF3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float EBEPFJIAOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xBD1EF0", Offset = "0xBD12F0", VA = "0x180BD1EF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x599BB70", Offset = "0x599AF70", VA = "0x18599BB70")]
	public T JIOINMCCIND(float DEEHPBDAIHI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x599BD50", Offset = "0x599B150", VA = "0x18599BD50")]
	public T OPNOKKFHAON(float DEEHPBDAIHI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BPKIFFIBDJB(T PPPJAHNPKAO, T DFIFINAEGII, float DEEHPBDAIHI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3540", Offset = "0x7AC2940", VA = "0x187AC3540", Slot = "4")]
	protected override float BPKIFFIBDJB(float PPPJAHNPKAO, float DFIFINAEGII, float DEEHPBDAIHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3580", Offset = "0x7AC2980", VA = "0x187AC3580")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16792A0", Offset = "0x16786A0", VA = "0x1816792A0", Slot = "4")]
	protected override Vector3 BPKIFFIBDJB(Vector3 PPPJAHNPKAO, Vector3 DFIFINAEGII, float DEEHPBDAIHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC74A0", Offset = "0x7AC68A0", VA = "0x187AC74A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3230", Offset = "0x7AC2630", VA = "0x187AC3230", Slot = "4")]
	protected override Color BPKIFFIBDJB(Color PPPJAHNPKAO, Color DFIFINAEGII, float DEEHPBDAIHI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7AC32F0", Offset = "0x7AC26F0", VA = "0x187AC32F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AKLDCOEBIJC : CBKOPHALCHB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1F90", Offset = "0x7AC1390", VA = "0x187AC1F90")]
	public AKLDCOEBIJC(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1F20", Offset = "0x7AC1320", VA = "0x187AC1F20", Slot = "6")]
	protected override uint DGDNNFCMOCD(uint MKLCJOILBMP, string OOEMJLHLIHJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HCCCOJLIFEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable IADGMEFIGGI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HCCCOJLIFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OPOPECAIHIB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DMMGALHBLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LNECEPOBCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int BMFFEFLPBEA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4D74830", Offset = "0x4D73C30", VA = "0x184D74830")]
	private OPOPECAIHIB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DCDLHKCMHEB, int OLDGNPMCFNG, int KPPBBAKFPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x537C9E0", Offset = "0x537BDE0", VA = "0x18537C9E0")]
	public static OPOPECAIHIB<T> FABCCGGAHMJ()
	{
		return default(OPOPECAIHIB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x537E110", Offset = "0x537D510", VA = "0x18537E110")]
	public (int, int, Task<T>) OCPDNFGPBKO(int FIFFOHPGPDL, [Optional] CancellationToken JDDHIJBJNHP, double FGNAOOMAGFL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x537C7C0", Offset = "0x537BBC0", VA = "0x18537C7C0")]
	public void AICGLCHONGM(int FIFFOHPGPDL, int KPPBBAKFPGO, [In] T APLCGCDLEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HFPEHCHPCCN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC36C0", Offset = "0x7AC2AC0", VA = "0x187AC36C0")]
	public static OPOPECAIHIB<FGGPIMEAIEJ> FABCCGGAHMJ()
	{
		return default(OPOPECAIHIB<FGGPIMEAIEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3640", Offset = "0x7AC2A40", VA = "0x187AC3640")]
	public static void AICGLCHONGM([In] this OPOPECAIHIB<FGGPIMEAIEJ> KBBJDOAJMAF, int FIFFOHPGPDL, int KPPBBAKFPGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class DPOKGANNFJP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> INKNOKDFNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> DECOKBBPNDD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3F693A0", Offset = "0x3F687A0", VA = "0x183F693A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HGFLKIPPAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> PDCDFPKJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x43B0300", Offset = "0x43AF700", VA = "0x1843B0300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> KCNBNAHBCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x496C020", Offset = "0x496B420", VA = "0x18496C020", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68F9450", Offset = "0x68F8850", VA = "0x1868F9450", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x68F94C0", Offset = "0x68F88C0", VA = "0x1868F94C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68F8F20", Offset = "0x68F8320", VA = "0x1868F8F20")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x68F8960", Offset = "0x68F7D60", VA = "0x1868F8960", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x68F9220", Offset = "0x68F8620", VA = "0x1868F9220", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68F8630", Offset = "0x68F7A30", VA = "0x1868F8630", Slot = "9")]
	public void Add(TKey IICGAABOENK, TVal OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68F8680", Offset = "0x68F7A80", VA = "0x1868F8680", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68F8A10", Offset = "0x68F7E10", VA = "0x1868F8A10", Slot = "8")]
	public bool ContainsKey(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68F8A70", Offset = "0x68F7E70", VA = "0x1868F8A70", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x68F91A0", Offset = "0x68F85A0", VA = "0x1868F91A0", Slot = "10")]
	public bool Remove(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x68F9160", Offset = "0x68F8560", VA = "0x1868F9160", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68F92C0", Offset = "0x68F86C0", VA = "0x1868F92C0", Slot = "11")]
	public bool TryGetValue(TKey IICGAABOENK, [Out] TVal OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68F8C40", Offset = "0x68F8040", VA = "0x1868F8C40", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x68F8AF0", Offset = "0x68F7EF0", VA = "0x1868F8AF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IMLJIFPAFGH, int MCHPHAOBGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68F8B80", Offset = "0x68F7F80", VA = "0x1868F8B80")]
	public bool EHIFOHHFDPG(TVal IICGAABOENK, [Out] TKey OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68F8F80", Offset = "0x68F8380", VA = "0x1868F8F80")]
	private void NBJDILPDPPO(TKey IICGAABOENK, TVal DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x68F8CE0", Offset = "0x68F80E0", VA = "0x1868F8CE0")]
	private void HKCMOMANPHI(TKey IICGAABOENK, TVal DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68F8830", Offset = "0x68F7C30", VA = "0x1868F8830")]
	private bool BCKMHKMPNLK(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x68F9320", Offset = "0x68F8720", VA = "0x1868F9320")]
	public DPOKGANNFJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class CPNFKALPELO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CPNFKALPELO<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4415360", Offset = "0x4414760", VA = "0x184415360", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x44237C0", Offset = "0x4422BC0", VA = "0x1844237C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4424040", Offset = "0x4423440", VA = "0x184424040")]
		public Enumerator(CPNFKALPELO<T> HDBNDELHALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4422410", Offset = "0x4421810", VA = "0x184422410", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4422B00", Offset = "0x4421F00", VA = "0x184422B00", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x44218D0", Offset = "0x4420CD0", VA = "0x1844218D0")]
		private void FCNFJHJNGGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] ILHAEJGFKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int NHKONNPHPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int BALEEEHNCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IPCFHGIMHJJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x665C970", Offset = "0x665BD70", VA = "0x18665C970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x665C5E0", Offset = "0x665B9E0", VA = "0x18665C5E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x665BB40", Offset = "0x665AF40", VA = "0x18665BB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x665CDD0", Offset = "0x665C1D0", VA = "0x18665CDD0")]
	public CPNFKALPELO(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x665ABE0", Offset = "0x6659FE0", VA = "0x18665ABE0")]
	public void FGAAHPGCDNG(T DEEHPBDAIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x665AAC0", Offset = "0x6659EC0", VA = "0x18665AAC0")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x665C860", Offset = "0x665BC60", VA = "0x18665C860")]
	public void MHONFCBAGNL(int PCGLBCNIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x665B430", Offset = "0x665A830", VA = "0x18665B430")]
	public void GEKINDBKALD(T[] IMLJIFPAFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x665CA60", Offset = "0x665BE60", VA = "0x18665CA60")]
	public Enumerator PMMOLBDEIOM()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x665CAE0", Offset = "0x665BEE0", VA = "0x18665CAE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x665CAE0", Offset = "0x665BEE0", VA = "0x18665CAE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x665C040", Offset = "0x665B440", VA = "0x18665C040")]
	private int LBKKLMHGFKF(int COPLIEINKOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x665C940", Offset = "0x665BD40", VA = "0x18665C940")]
	private int NGNDBAJOGAF(int COPLIEINKOF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KEOMCGFNNEA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> DMBEAKEIJPB(TRequest LFFAIMMKIAM, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum GEGHOGJHKEC
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DMMBFDOJOIK
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float ODDMNFNFCEG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan BHPDCONHEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int BHHKMENBJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GEGHOGJHKEC AHAADDELNCC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly DMMBFDOJOIK GCAAODGDGAI;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float BLDNCBNELMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x68F21B0", Offset = "0x68F15B0", VA = "0x1868F21B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan DIIJAMKBJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x68F2290", Offset = "0x68F1690", VA = "0x1868F2290")]
		public DMMBFDOJOIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct IKGEIBDLDHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest LFFAIMMKIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken JDDHIJBJNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> BGBOPFLGEHK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A650B0", Offset = "0x4A644B0", VA = "0x184A650B0")]
		public IKGEIBDLDHH(TRequest LFFAIMMKIAM, TaskCompletionSource<TResult> BGBOPFLGEHK, CancellationToken JDDHIJBJNHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct EPINDCAHBOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public KEOMCGFNNEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x43BD5A0", Offset = "0x43BC9A0", VA = "0x1843BD5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x43BDA70", Offset = "0x43BCE70", VA = "0x1843BDA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct PLNBOFOMLEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KEOMCGFNNEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IKGEIBDLDHH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x54B5170", Offset = "0x54B4570", VA = "0x1854B5170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x54B6430", Offset = "0x54B5830", VA = "0x1854B6430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource GIAHPKIENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<IKGEIBDLDHH> HJJLJKJOBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DMMBFDOJOIK KJKGMKFKLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DMBEAKEIJPB IANGIHNDLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task HILIIJNHBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BLLHJPGLJNE;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7CA0", Offset = "0x4DE70A0", VA = "0x184DE7CA0")]
	public KEOMCGFNNEA(DMBEAKEIJPB IANGIHNDLPO, [Optional] DMMBFDOJOIK KJKGMKFKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE66E0", Offset = "0x4DE5AE0", VA = "0x184DE66E0")]
	public Task<TResult> BJDAJIAGKII(TRequest LFFAIMMKIAM, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4DE78F0", Offset = "0x4DE6CF0", VA = "0x184DE78F0")]
	private void HLIBPABIPIM(IKGEIBDLDHH FNLIPPAADON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6540", Offset = "0x4DE5940", VA = "0x184DE6540")]
	[AsyncStateMachine(typeof(KEOMCGFNNEA<, >.EPINDCAHBOL))]
	private Task BCJJDNCJGBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6DF0", Offset = "0x4DE61F0", VA = "0x184DE6DF0")]
	private IKGEIBDLDHH CIHHHEBENOF()
	{
		return default(IKGEIBDLDHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7AB0", Offset = "0x4DE6EB0", VA = "0x184DE7AB0")]
	[AsyncStateMachine(typeof(KEOMCGFNNEA<, >.PLNBOFOMLEP))]
	private Task MOEPCGHFKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6360", Offset = "0x4DE5760", VA = "0x184DE6360")]
	private void AJBHJHKNOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DE76F0", Offset = "0x4DE6AF0", VA = "0x184DE76F0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class ELMDPAKIDAI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> ANHMDLEGCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> LFMOIPOMFOP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F693A0", Offset = "0x3F687A0", VA = "0x183F693A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HGFLKIPPAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x36EEFD0", Offset = "0x36EE3D0", VA = "0x1836EEFD0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x43AD400", Offset = "0x43AC800", VA = "0x1843AD400", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x43AC580", Offset = "0x43AB980", VA = "0x1843AC580", Slot = "11")]
	public void Add(T NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x43ACAC0", Offset = "0x43ABEC0", VA = "0x1843ACAC0")]
	public bool KGNGOCHPJJM(T NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x43ACFA0", Offset = "0x43AC3A0", VA = "0x1843ACFA0", Slot = "15")]
	public bool Remove(T NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x43AC730", Offset = "0x43ABB30", VA = "0x1843AC730", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43AD140", Offset = "0x43AC540", VA = "0x1843AD140", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43AC5C0", Offset = "0x43AB9C0", VA = "0x1843AC5C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x43AC670", Offset = "0x43ABA70", VA = "0x1843AC670", Slot = "13")]
	public bool Contains(T NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x43AC6D0", Offset = "0x43ABAD0", VA = "0x1843AC6D0", Slot = "14")]
	public void CopyTo(T[] IMLJIFPAFGH, int MCHPHAOBGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x43AC7C0", Offset = "0x43ABBC0", VA = "0x1843AC7C0", Slot = "6")]
	public int IndexOf(T NNAMOJMJBHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x43AC820", Offset = "0x43ABC20", VA = "0x1843AC820", Slot = "7")]
	public void Insert(int COPLIEINKOF, T NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x43ACCE0", Offset = "0x43AC0E0", VA = "0x1843ACCE0", Slot = "8")]
	public void RemoveAt(int COPLIEINKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x43AD180", Offset = "0x43AC580", VA = "0x1843AD180")]
	public ELMDPAKIDAI()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2930B80", Offset = "0x292FF80", VA = "0x182930B80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2476A80", Offset = "0x2475E80", VA = "0x182476A80")]
		public SerializedGuid([In] Guid FIAGFFPOAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC68F0", Offset = "0x7AC5CF0", VA = "0x187AC68F0")]
		public static SerializedGuid NADNJGGGEGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6710", Offset = "0x7AC5B10", VA = "0x187AC6710")]
		public static SerializedGuid CLKEJCGEJEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6880", Offset = "0x7AC5C80", VA = "0x187AC6880")]
		public bool GHONCNALJFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC69F0", Offset = "0x7AC5DF0", VA = "0x187AC69F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6970", Offset = "0x7AC5D70", VA = "0x187AC6970", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7AC67B0", Offset = "0x7AC5BB0", VA = "0x187AC67B0", Slot = "7")]
		public bool Equals(SerializedGuid DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AC67F0", Offset = "0x7AC5BF0", VA = "0x187AC67F0", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC68E0", Offset = "0x7AC5CE0", VA = "0x187AC68E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6780", Offset = "0x7AC5B80", VA = "0x187AC6780", Slot = "6")]
		public int CompareTo(SerializedGuid DMMBOHMLHLF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NNMLEKAJNEN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type BLGNPNLENAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string DNOFCEHPCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool HFAKGKLFHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool OFDGPHKAIDK;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4E50", Offset = "0x7AC4250", VA = "0x187AC4E50")]
	public NNMLEKAJNEN(Type KILOFMEBHAC, string EBKMIDCJCPG, bool KBPNIHJMOJL = false, bool OHEOFJFEGIC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OCOAFCJHJFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int NMGJLAJBPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> HMMLCHKPMGM(float ILKAOEMIOFJ, [Optional] float? LFOHAHKNIEL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OCPFAKLANBH(float ILKAOEMIOFJ, T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENAIKFMHAAL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class NACLNDCMLPO<T> : OCOAFCJHJFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class OMLOKBCNIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float GDMKJMNANGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T APFNDOMNAPN;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OMLOKBCNIHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ONLMJPECNLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ONLMJPECNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5375080", Offset = "0x5374480", VA = "0x185375080")]
		internal bool INJJOMPKIDM(OMLOKBCNIHK sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float DMDBLGDBDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float FKCMPJNDMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<OMLOKBCNIHK> AMDILILIPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FMGMEFJMHDH<OMLOKBCNIHK> DIMNAOOKKEL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NMGJLAJBPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5152990", Offset = "0x5151D90", VA = "0x185152990", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5152DD0", Offset = "0x51521D0", VA = "0x185152DD0")]
	public NACLNDCMLPO(float MJOBFHKIIAC, float ENCOKANHPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5152BE0", Offset = "0x5151FE0", VA = "0x185152BE0", Slot = "6")]
	public bool OCPFAKLANBH(float ILKAOEMIOFJ, T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5152020", Offset = "0x5151420", VA = "0x185152020", Slot = "5")]
	public IEnumerable<T> HMMLCHKPMGM(float ILKAOEMIOFJ, float? LFOHAHKNIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5151F60", Offset = "0x5151360", VA = "0x185151F60", Slot = "7")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5152760", Offset = "0x5151B60", VA = "0x185152760")]
	private void MMBMNJGHNIK(float ILKAOEMIOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class ILIEEIEDIFJ<T> : OCOAFCJHJFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct AJFKEIIKBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T APFNDOMNAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float GDMKJMNANGP;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x47F3E60", Offset = "0x47F3260", VA = "0x1847F3E60")]
		public AJFKEIIKBKP(T OOEMJLHLIHJ, float ILKAOEMIOFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class DIKDAEGEFPA : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ILIEEIEDIFJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public DIKDAEGEFPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6899D10", Offset = "0x6899110", VA = "0x186899D10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x689A0F0", Offset = "0x68994F0", VA = "0x18689A0F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6899FC0", Offset = "0x68993C0", VA = "0x186899FC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x48745E0", Offset = "0x48739E0", VA = "0x1848745E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float MJOBFHKIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float ENCOKANHPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<AJFKEIIKBKP> AMDILILIPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int NHKONNPHPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int CBJNNOHBBPO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int NMGJLAJBPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4A66B40", Offset = "0x4A65F40", VA = "0x184A66B40")]
	public ILIEEIEDIFJ(float MJOBFHKIIAC, float ENCOKANHPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4A66470", Offset = "0x4A65870", VA = "0x184A66470", Slot = "6")]
	public bool OCPFAKLANBH(float ILKAOEMIOFJ, T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4A65DD0", Offset = "0x4A651D0", VA = "0x184A65DD0", Slot = "8")]
	public int HIDCPLOFOAD(float ILKAOEMIOFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4A65E20", Offset = "0x4A65220", VA = "0x184A65E20", Slot = "5")]
	[IteratorStateMachine(typeof(ILIEEIEDIFJ<>.DIKDAEGEFPA))]
	public IEnumerable<T> HMMLCHKPMGM(float ILKAOEMIOFJ, float? LFOHAHKNIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A65D70", Offset = "0x4A65170", VA = "0x184A65D70", Slot = "7")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A65FC0", Offset = "0x4A653C0", VA = "0x184A65FC0")]
	private void IDILFPOFLAA(float ILKAOEMIOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A66760", Offset = "0x4A65B60", VA = "0x184A66760")]
	private AJFKEIIKBKP PKGHMHFKFFO()
	{
		return default(AJFKEIIKBKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BNJJFADPKOK<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct FLAPCIIPMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long LECGCKNPNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long EGKLMDHEFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int NLGNLJBNADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int PFOEOKKIBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool IJAOOOJDICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string BLPJADFBJLK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x47E8360", Offset = "0x47E7760", VA = "0x1847E8360")]
		public FLAPCIIPMMI(long LECGCKNPNIC, int NLGNLJBNADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x47E83D0", Offset = "0x47E77D0", VA = "0x1847E83D0")]
		public FLAPCIIPMMI(long LECGCKNPNIC, long EGKLMDHEFLM, int NLGNLJBNADH, int PFOEOKKIBIB, bool IJAOOOJDICE, string BLPJADFBJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x47E81F0", Offset = "0x47E75F0", VA = "0x1847E81F0")]
		public int EIEAIENCAGD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x47E8240", Offset = "0x47E7640", VA = "0x1847E8240")]
		public int GAFEINDNKFD(int ADBKDOCLNLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x47E8260", Offset = "0x47E7660", VA = "0x1847E8260")]
		public double GHBDCCPAJIN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x47E82C0", Offset = "0x47E76C0", VA = "0x1847E82C0")]
		public FLAPCIIPMMI OGKLHIHABJC(long EGKLMDHEFLM, int PFOEOKKIBIB)
		{
			return default(FLAPCIIPMMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class EFJIBBJEOLP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct LKEBLPIBCEI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public EFJIBBJEOLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<EFJIBBJEOLP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private EFJIBBJEOLP <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4ECA2A0", Offset = "0x4EC96A0", VA = "0x184ECA2A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x48D6B10", Offset = "0x48D5F10", VA = "0x1848D6B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey HGAANBOBAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly BNJJFADPKOK<TKey> IHAAMEONBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly LMKAPNBAFDO KIBGFJNEFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<EFJIBBJEOLP> EMPIFLHCKKM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string HMPKHMCLNFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x438BD70", Offset = "0x438B170", VA = "0x18438BD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<EFJIBBJEOLP> DNOAAJMKEHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x438BF90", Offset = "0x438B390", VA = "0x18438BF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public FLAPCIIPMMI CJGJGOJLINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x438BD50", Offset = "0x438B150", VA = "0x18438BD50")]
			[CompilerGenerated]
			get
			{
				return default(FLAPCIIPMMI);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x438BD20", Offset = "0x438B120", VA = "0x18438BD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x438BFD0", Offset = "0x438B3D0", VA = "0x18438BFD0")]
		internal EFJIBBJEOLP(BNJJFADPKOK<TKey> IHAAMEONBJO, TKey IICGAABOENK, LMKAPNBAFDO KIBGFJNEFGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x438BDD0", Offset = "0x438B1D0", VA = "0x18438BDD0")]
		public EFJIBBJEOLP NIDEHDGDBLL(TKey IICGAABOENK, [Optional] LMKAPNBAFDO? GEAKBJFCMIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5CD0", Offset = "0x3AD50D0", VA = "0x183AD5CD0")]
		[AsyncStateMachine(typeof(LKEBLPIBCEI<>))]
		public Task<T> NAHGBNPCBOC<T>(TKey IICGAABOENK, Func<EFJIBBJEOLP, Task<T>> JMBBGOMJFAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x438BAC0", Offset = "0x438AEC0", VA = "0x18438BAC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JEBFMHPMLBN : IEnumerable<(TKey, List<TKey>, FLAPCIIPMMI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FLAPCIIPMMI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, FLAPCIIPMMI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BNJJFADPKOK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, FLAPCIIPMMI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, FLAPCIIPMMI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2918CB0", Offset = "0x29180B0", VA = "0x182918CB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FLAPCIIPMMI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4C88AA0", Offset = "0x4C87EA0", VA = "0x184C88AA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2918DA0", Offset = "0x29181A0", VA = "0x182918DA0")]
		[DebuggerHidden]
		public JEBFMHPMLBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x481FFA0", Offset = "0x481F3A0", VA = "0x18481FFA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4C885C0", Offset = "0x4C879C0", VA = "0x184C885C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4C88570", Offset = "0x4C87970", VA = "0x184C88570")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4C88A50", Offset = "0x4C87E50", VA = "0x184C88A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4C88970", Offset = "0x4C87D70", VA = "0x184C88970", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FLAPCIIPMMI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4827940", Offset = "0x4826D40", VA = "0x184827940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EPGEFPALNPK : IEnumerable<(TKey, List<TKey>, FLAPCIIPMMI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FLAPCIIPMMI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, FLAPCIIPMMI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EFJIBBJEOLP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EFJIBBJEOLP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public BNJJFADPKOK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<EFJIBBJEOLP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, FLAPCIIPMMI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, FLAPCIIPMMI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2918CB0", Offset = "0x29180B0", VA = "0x182918CB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FLAPCIIPMMI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x43BC0D0", Offset = "0x43BB4D0", VA = "0x1843BC0D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2918DA0", Offset = "0x29181A0", VA = "0x182918DA0")]
		[DebuggerHidden]
		public EPGEFPALNPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x43BC130", Offset = "0x43BB530", VA = "0x1843BC130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x43BB750", Offset = "0x43BAB50", VA = "0x1843BB750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x43BB690", Offset = "0x43BAA90", VA = "0x1843BB690")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x43BB6F0", Offset = "0x43BAAF0", VA = "0x1843BB6F0")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x43BC080", Offset = "0x43BB480", VA = "0x1843BC080", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x43BBF40", Offset = "0x43BB340", VA = "0x1843BBF40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FLAPCIIPMMI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x43BC040", Offset = "0x43BB440", VA = "0x1843BC040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, FLAPCIIPMMI, LMKAPNBAFDO> HHONNHACJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, FLAPCIIPMMI, LMKAPNBAFDO> KOBKJEBKLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<BNJJFADPKOK<TKey>, LMKAPNBAFDO> BKIFDAOHLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly EFJIBBJEOLP LNFIALNDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool FJEDLGBMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int AOFEGBPIAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch FBIALFCHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int BMJDMLBEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string MLDGFIKEOMF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EFJIBBJEOLP FMOHDJDEDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string HMPKHMCLNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6083B40", Offset = "0x6082F40", VA = "0x186083B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6083D40", Offset = "0x6083140", VA = "0x186083D40")]
	public BNJJFADPKOK(TKey OFCBMFHEAOB, LMKAPNBAFDO KIBGFJNEFGA, [Optional] int? NLGNLJBNADH, [Optional][CanBeNull] Stopwatch FBIALFCHEPM, [Optional] Action<TKey, FLAPCIIPMMI, LMKAPNBAFDO> HHONNHACJPN, [Optional] Action<TKey, FLAPCIIPMMI, LMKAPNBAFDO> KOBKJEBKLCH, [Optional] Action<BNJJFADPKOK<TKey>, LMKAPNBAFDO> BKIFDAOHLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x60839E0", Offset = "0x6082DE0", VA = "0x1860839E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6083C90", Offset = "0x6083090", VA = "0x186083C90")]
	[IteratorStateMachine(typeof(BNJJFADPKOK<>.JEBFMHPMLBN))]
	public IEnumerable<(TKey, List<TKey>, FLAPCIIPMMI)> LKCADOAIDEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6083BA0", Offset = "0x6082FA0", VA = "0x186083BA0")]
	[IteratorStateMachine(typeof(BNJJFADPKOK<>.EPGEFPALNPK))]
	private IEnumerable<(TKey, List<TKey>, FLAPCIIPMMI)> LKCADOAIDEB(List<TKey> BHKOPEBBFJK, EFJIBBJEOLP MOHPBCGNFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6083AC0", Offset = "0x6082EC0", VA = "0x186083AC0")]
	private (long, int) HHILEINFHBC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class AENBPALOBIC<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JAEHGGPNHGE(BNJJFADPKOK<TKey> IHAAMEONBJO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected AENBPALOBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class LOOBMKFKHIM<TKey> : AENBPALOBIC<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string JDKJFGNDEAC(TKey IICGAABOENK);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3FE0", Offset = "0x4ED33E0", VA = "0x184ED3FE0")]
	private static string FEEGFBLIBKN(TKey IICGAABOENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4180", Offset = "0x4ED3580", VA = "0x184ED4180", Slot = "4")]
	public override string JAEHGGPNHGE(BNJJFADPKOK<TKey> IHAAMEONBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4020", Offset = "0x4ED3420", VA = "0x184ED4020")]
	public string JAEHGGPNHGE(BNJJFADPKOK<TKey> IHAAMEONBJO, [NotNull] JDKJFGNDEAC OCPPEMDDIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NGLDMFJKPJC(BNJJFADPKOK<TKey> IHAAMEONBJO, [NotNull] JDKJFGNDEAC OCPPEMDDIED);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x497C050", Offset = "0x497B450", VA = "0x18497C050")]
	protected LOOBMKFKHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CCNBGKEEHIM<TKey> : AENBPALOBIC<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string LEPPEJJIDLK(TKey IICGAABOENK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string EJIPKKDAJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double HHAOEJPICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool OPPALCEELCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int HCJHABJIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> KCMMEJAHAHH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x64654A0", Offset = "0x64648A0", VA = "0x1864654A0")]
	private static string FEEGFBLIBKN(TKey IICGAABOENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6465D00", Offset = "0x6465100", VA = "0x186465D00")]
	public CCNBGKEEHIM(string EJIPKKDAJMJ = "F2", double HHAOEJPICKB = double.MaxValue, bool OPPALCEELCN = false, int HCJHABJIHKL = int.MaxValue, [Optional] ISet<string> KCMMEJAHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x64655C0", Offset = "0x64649C0", VA = "0x1864655C0", Slot = "4")]
	public override Dictionary<string, string> JAEHGGPNHGE(BNJJFADPKOK<TKey> IHAAMEONBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x64654E0", Offset = "0x64648E0", VA = "0x1864654E0")]
	private bool GFHOONBKMEA(string LCGHJNJGLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x64656B0", Offset = "0x6464AB0", VA = "0x1864656B0")]
	public Dictionary<string, string> JAEHGGPNHGE(BNJJFADPKOK<TKey> IHAAMEONBJO, LEPPEJJIDLK OCPPEMDDIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x64650C0", Offset = "0x64644C0", VA = "0x1864650C0")]
	private string BFAPHAAIMLE(StringBuilder LMJKKKMMHGP, List<TKey> MKIIOLEGINB, LEPPEJJIDLK OCPPEMDDIED, bool JGCLKLBOLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6465340", Offset = "0x6464740", VA = "0x186465340")]
	private static void CCJNPMHIDKC(StringBuilder GDKLHOLJIIO, string IGOIHLEKNJM, bool ELBIKOHMALO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class JNCBIGPMCCP<TKey> : LOOBMKFKHIM<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LCHJIPEGPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JDKJFGNDEAC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static JNCBIGPMCCP<TKey> IADGMEFIGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] GPFMMDAAFJB;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4CBD600", Offset = "0x4CBCA00", VA = "0x184CBD600")]
	private JNCBIGPMCCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC650", Offset = "0x4CBBA50", VA = "0x184CBC650", Slot = "5")]
	protected override string NGLDMFJKPJC(BNJJFADPKOK<TKey> IHAAMEONBJO, JDKJFGNDEAC OCPPEMDDIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC540", Offset = "0x4CBB940", VA = "0x184CBC540")]
	[CompilerGenerated]
	internal static string ECGCIHLCGBC(string BFGGAILGEJB, TKey IICGAABOENK, LCHJIPEGPMO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class FPOECAFJMLH : BNJJFADPKOK<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JGNOLKCBGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<FPOECAFJMLH, LMKAPNBAFDO> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JGNOLKCBGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3F10", Offset = "0x7AC3310", VA = "0x187AC3F10")]
		internal void BDBCPOGKOJO(BNJJFADPKOK<string> timer, LMKAPNBAFDO log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC33F0", Offset = "0x7AC27F0", VA = "0x187AC33F0")]
	public FPOECAFJMLH(LMKAPNBAFDO KIBGFJNEFGA, [Optional] string PALHOHABGHG, [Optional] int? NLGNLJBNADH, [Optional] Stopwatch FBIALFCHEPM, [Optional] Action<string, FLAPCIIPMMI, LMKAPNBAFDO> HHONNHACJPN, [Optional] Action<string, FLAPCIIPMMI, LMKAPNBAFDO> KOBKJEBKLCH, [Optional] Action<FPOECAFJMLH, LMKAPNBAFDO> BKIFDAOHLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3330", Offset = "0x7AC2730", VA = "0x187AC3330")]
	private static Action<BNJJFADPKOK<string>, LMKAPNBAFDO> LAIBKPMANPC(Action<FPOECAFJMLH, LMKAPNBAFDO> IBDCICFCEPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class ILBMIHHFBJH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class OIBOLGFIJNB : ILBMIHHFBJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static ILBMIHHFBJH IADGMEFIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7AC51B0", Offset = "0x7AC45B0", VA = "0x187AC51B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float NOIMMOHKIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1158860", Offset = "0x1157C60", VA = "0x181158860", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7AC52B0", Offset = "0x7AC46B0", VA = "0x187AC52B0")]
		public OIBOLGFIJNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static ILBMIHHFBJH KEECKMCKDBK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static ILBMIHHFBJH GCAAODGDGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3AC0", Offset = "0x7AC2EC0", VA = "0x187AC3AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float NOIMMOHKIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected ILBMIHHFBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BFNBKBNLNFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PKCCCOBBKFK<T> : BFNBKBNLNFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> CEINLNPIGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	NDJGFNKMCGL<T> DLOCJGDCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OGKNEDIKAOO
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x38AD6D0", Offset = "0x38ACAD0", VA = "0x1838AD6D0")]
	public static PKCCCOBBKFK<TResource> FILMJBHFBNN<TResource, TId>(this GFGPLDJIGJO<TId, TResource> NMAEEMHJHKP, TId FBLIJIPJKFJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? GJFDGLJHIFA) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EPGPFCFDCNL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class FIALADKFLGG<T> : CLHFDPEPGEL<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> CEINLNPIGOG
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NDJGFNKMCGL<T?> DLOCJGDCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x47D9F60", Offset = "0x47D9360", VA = "0x1847D9F60")]
		public FIALADKFLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "10")]
		protected override void MHDALAAPKGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class IPNADHNMGKM<T> : CLHFDPEPGEL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T LMKKPAFNKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? HFOILBEEGHE;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> CEINLNPIGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NDJGFNKMCGL<T> DLOCJGDCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4A81760", Offset = "0x4A80B60", VA = "0x184A81760")]
		public IPNADHNMGKM(T KJFLMPPOCMG, Action<T>? PNIEGCAPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4A81700", Offset = "0x4A80B00", VA = "0x184A81700", Slot = "10")]
		protected override void MHDALAAPKGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class DGKLDENMBNA<T> : CLHFDPEPGEL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> CEINLNPIGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NDJGFNKMCGL<T> DLOCJGDCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6892F50", Offset = "0x6892350", VA = "0x186892F50")]
		public DGKLDENMBNA(Exception OHPACGAIPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "10")]
		protected override void MHDALAAPKGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class NJLCEPJJHFJ<T> : CLHFDPEPGEL<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct GNFNEADAINO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<PKCCCOBBKFK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PKCCCOBBKFK<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x48C9A50", Offset = "0x48C8E50", VA = "0x1848C9A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x48CA4B0", Offset = "0x48C98B0", VA = "0x1848CA4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct EHGBJBMADJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<PKCCCOBBKFK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<PKCCCOBBKFK<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x43970B0", Offset = "0x43964B0", VA = "0x1843970B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4397530", Offset = "0x4396930", VA = "0x184397530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<PKCCCOBBKFK<T>> KEFKHAEEMNF;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> CEINLNPIGOG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NDJGFNKMCGL<T> DLOCJGDCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5223900", Offset = "0x5222D00", VA = "0x185223900")]
		public NJLCEPJJHFJ(Task<PKCCCOBBKFK<T>> OOCBIOLELBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5223870", Offset = "0x5222C70", VA = "0x185223870", Slot = "10")]
		protected override void MHDALAAPKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5223480", Offset = "0x5222880", VA = "0x185223480")]
		[AsyncStateMachine(typeof(NJLCEPJJHFJ<>.GNFNEADAINO))]
		[CompilerGenerated]
		internal static Task<T> CLKCDDJBIEO(Task<PKCCCOBBKFK<T>> OOCBIOLELBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5223600", Offset = "0x5222A00", VA = "0x185223600")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(NJLCEPJJHFJ<>.EHGBJBMADJN))]
		internal static Task KPOADOEBJGE(Task<PKCCCOBBKFK<T>> OOCBIOLELBN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class PPMDLLMMDIE<TIn, TOut> : CLHFDPEPGEL<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct JPLJOEBOLKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4CCA940", Offset = "0x4CC9D40", VA = "0x184CCA940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4CBBEE0", Offset = "0x4CBB2E0", VA = "0x184CBBEE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly PKCCCOBBKFK<TIn> CPBPOLGBCIK;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> CEINLNPIGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NDJGFNKMCGL<TOut> DLOCJGDCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x54CEEA0", Offset = "0x54CE2A0", VA = "0x1854CEEA0")]
		public PPMDLLMMDIE(PKCCCOBBKFK<TIn> EOPHFBMFAAM, Func<TIn, TOut> EOFOAOPNKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x54CEE00", Offset = "0x54CE200", VA = "0x1854CEE00", Slot = "10")]
		protected override void MHDALAAPKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x54CEC70", Offset = "0x54CE070", VA = "0x1854CEC70")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(PPMDLLMMDIE<, >.JPLJOEBOLKH))]
		internal static Task<TOut> GHELJNNMMFE(Task<TIn> JELKEOBCBOD, Func<TIn, TOut> EOFOAOPNKDD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x353FE30", Offset = "0x353F230", VA = "0x18353FE30")]
	public static PKCCCOBBKFK<T> HGNIBOKIJFN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x353FD80", Offset = "0x353F180", VA = "0x18353FD80")]
	public static PKCCCOBBKFK<T> DEOHBHIMLGI<T>(T APLCGCDLEGH, [Optional] Action<T>? PNIEGCAPKKL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
	public static PKCCCOBBKFK<T> KEAJOBMNDJO<T>(Exception OHPACGAIPAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
	public static PKCCCOBBKFK<T> IPPHFLAGJBM<T>(Task<PKCCCOBBKFK<T>> OOCBIOLELBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x34FC3B0", Offset = "0x34FB7B0", VA = "0x1834FC3B0")]
	public static PKCCCOBBKFK<TOut> ACIFLJLGGLL<TOut, TIn>(PKCCCOBBKFK<TIn> PAOMPCHHBKF, Func<TIn, TOut> EOFOAOPNKDD) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class CLHFDPEPGEL<T> : PKCCCOBBKFK<T>, BFNBKBNLNFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string IFEBHNOGKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly FMDNBBJKFJO FPLEBCDMDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool FJEDLGBMFFE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xC46900", Offset = "0xC45D00", VA = "0x180C46900", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> CEINLNPIGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract NDJGFNKMCGL<T> DLOCJGDCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x66306B0", Offset = "0x662FAB0", VA = "0x1866306B0")]
	public CLHFDPEPGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6630370", Offset = "0x662F770", VA = "0x186630370", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MHDALAAPKGE();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class LGJCKJIHGIM<TTask, T> : CLHFDPEPGEL<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class DACNKLIIMKK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public DACNKLIIMKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3F56FD0", Offset = "0x3F563D0", VA = "0x183F56FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3F572A0", Offset = "0x3F566A0", VA = "0x183F572A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LGJCKJIHGIM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DACNKLIIMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x684B390", Offset = "0x684A790", VA = "0x18684B390")]
		[AsyncStateMachine(typeof(LGJCKJIHGIM<, >.DACNKLIIMKK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DOHICIEEBLA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> OOCBIOLELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource LOIPKDKGEPO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> CEINLNPIGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override NDJGFNKMCGL<T> DLOCJGDCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8880", Offset = "0x4EB7C80", VA = "0x184EB8880")]
	protected LGJCKJIHGIM(TTask OOCBIOLELBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8830", Offset = "0x4EB7C30", VA = "0x184EB8830", Slot = "10")]
	protected override void MHDALAAPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T KBMOOBJAMDG(TTask IPLNFKCIDBN);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DIIFFIKCKMH();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FEOECEHPKEK<T> : CLHFDPEPGEL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly BCNNKHLMADP<Task<T>> JOFGNCDGKKK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> CEINLNPIGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x47D6970", Offset = "0x47D5D70", VA = "0x1847D6970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override NDJGFNKMCGL<T> DLOCJGDCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x47D69F0", Offset = "0x47D5DF0", VA = "0x1847D69F0")]
	public FEOECEHPKEK(BCNNKHLMADP<Task<T>> AOLHNBFLAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x47D69D0", Offset = "0x47D5DD0", VA = "0x1847D69D0", Slot = "10")]
	protected override void MHDALAAPKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NMOIBDDDONO
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName GGLAFLCOAKL;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> AEPCEDIFMCC;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7AC45E0", Offset = "0x7AC39E0", VA = "0x187AC45E0")]
	public static int GJDGPIPBAML(this GDMHIEJBDAJ HDOCGCBBIMI, IncrementalHash MKLCJOILBMP, byte[] AEPMMIOGJPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4CA0", Offset = "0x7AC40A0", VA = "0x187AC4CA0")]
	public static bool OPCGCMCDCMB([CanBeNull] this GDMHIEJBDAJ HDOCGCBBIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4660", Offset = "0x7AC3A60", VA = "0x187AC4660")]
	public static bool OPCGCMCDCMB([CanBeNull] this GDMHIEJBDAJ HDOCGCBBIMI, [Out] string MHFONFLBJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4970", Offset = "0x7AC3D70", VA = "0x187AC4970")]
	public static bool OPCGCMCDCMB([CanBeNull] this GDMHIEJBDAJ HDOCGCBBIMI, IncrementalHash MKLCJOILBMP, byte[] AEPMMIOGJPI, [Out] string MHFONFLBJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4550", Offset = "0x7AC3950", VA = "0x187AC4550")]
	private static bool CJMEJMKCBMM(byte[] OGMAGNPDDBD, Span<byte> AMCKLFMJDOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IAMPIAOBEPO
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3710", Offset = "0x7AC2B10", VA = "0x187AC3710")]
	public static int DLJCGGDODJL(HashAlgorithmName FJDCOHHAFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3860", Offset = "0x7AC2C60", VA = "0x187AC3860")]
	public static int GJDGPIPBAML(this FPLHDPGGOJE AKIGIFEEJDB, byte[] ODMKGDCCPPN, IncrementalHash MKLCJOILBMP, byte[] AFODJDKGBCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface FPLHDPGGOJE
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MKLCJOILBMP);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface GDMHIEJBDAJ : FPLHDPGGOJE
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] EBFBEJOKKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] NKJPPCBEGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AHPKLINGJOB
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool CHLKJMMNCNP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> NIIHKCNJFGG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> PBFENHKHPGO;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding OLEMOFPNGMC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> FPOILHDJPIE;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B4B0", Offset = "0x3E5A8B0", VA = "0x183E5B4B0")]
	public static void OMGHDMBJLDF<T>(this IncrementalHash MHMOOPHIOOG, [CanBeNull] T FBIFMODNLFM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B420", Offset = "0x3E5A820", VA = "0x183E5B420")]
	public static void OIIAEKOCGCJ<T>(this IncrementalHash MHMOOPHIOOG, [CanBeNull] T AKIGIFEEJDB) where T : FPLHDPGGOJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AF00", Offset = "0x3E5A300", VA = "0x183E5AF00")]
	public static void LMHJAKOHDDC<T>(this IncrementalHash MHMOOPHIOOG, [CanBeNull] IList<T> FGENNLMIPKI) where T : FPLHDPGGOJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0D40", Offset = "0x7AC0140", VA = "0x187AC0D40")]
	private static bool BBIMDLNDDCP([CanBeNull] FPLHDPGGOJE AKIGIFEEJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0DD0", Offset = "0x7AC01D0", VA = "0x187AC0DD0")]
	public static void BODBLCCGGBJ(this IncrementalHash MKLCJOILBMP, string? NKHCLENOMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1580", Offset = "0x7AC0980", VA = "0x187AC1580")]
	public static void GFPLPKLDIEI(this IncrementalHash MKLCJOILBMP, long PIGKIMPDKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7AC18E0", Offset = "0x7AC0CE0", VA = "0x187AC18E0")]
	public static void NCGAJHNFCID(this IncrementalHash MKLCJOILBMP, int NOCHNDBLDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1AB0", Offset = "0x7AC0EB0", VA = "0x187AC1AB0")]
	public static void OCEECNLCDHP(this IncrementalHash MKLCJOILBMP, short CJAOJBGBOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7AC12A0", Offset = "0x7AC06A0", VA = "0x187AC12A0")]
	public static void EMBPGPAOFFL(this IncrementalHash MKLCJOILBMP, byte KEIJDIKIKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7AC13B0", Offset = "0x7AC07B0", VA = "0x187AC13B0")]
	public static void FBNAFOJJNCA(this IncrementalHash MKLCJOILBMP, bool ELOKALGDBED, bool OFHNKDNCKFD = false, bool IBEOLLJLMDH = false, bool BHHFEHNNIHJ = false, bool GGGLAKPBLJC = false, bool ECINCJEAGJD = false, bool MHKIOEGNDJN = false, bool MLCEIOGJHNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A8D0", Offset = "0x3E59CD0", VA = "0x183E5A8D0")]
	public static void FJHCPGGIGKN<T>(this IncrementalHash MKLCJOILBMP, T AGBLNABJHCB) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1750", Offset = "0x7AC0B50", VA = "0x187AC1750")]
	public static void HFCIMEMGBHN(this IncrementalHash MKLCJOILBMP, float COHJDIHFALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC11E0", Offset = "0x7AC05E0", VA = "0x187AC11E0")]
	public static void CIBNBNLNNLJ(this IncrementalHash MKLCJOILBMP, ulong DCOPJBOANDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1240", Offset = "0x7AC0640", VA = "0x187AC1240")]
	public static void EAOIAJIIINC(this IncrementalHash MKLCJOILBMP, uint NFMILGDGFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1520", Offset = "0x7AC0920", VA = "0x187AC1520")]
	public static void FGALDGHABFJ(this IncrementalHash MKLCJOILBMP, ushort PIODBBNGPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC17B0", Offset = "0x7AC0BB0", VA = "0x187AC17B0")]
	public static void MMGJBCPECFM(this IncrementalHash MKLCJOILBMP, Vector3 IMPKEBHOMIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OEDJNOIFLJI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5150", Offset = "0x7AC4550", VA = "0x187AC5150")]
	public OEDJNOIFLJI(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class LHBGFCAOKDP
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void COFAPHJOHPH(ushort OFOJCBEIHEA, ushort JBLNKAAKHEP, ushort GAJJHOHJKPC, ushort LBBJHFIAGBK);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void ALKODCCDJJD(ushort KFGNHDNEIHO, ushort HHDJLJNLBIE);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void LMKDFJAOCFI();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort EDPHPOEHCKA = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected LHBGFCAOKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class IMAIBPEBABC<T> : LHBGFCAOKDP where T : IMAIBPEBABC<T>.AKLGDBBCEJF
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface AKLGDBBCEJF
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		ALKODCCDJJD AOPPDDNCBON
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		ALKODCCDJJD DJKEFFIDPNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		LMKDFJAOCFI AKEELCJADEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> FCLICKOEFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LMKDFJAOCFI PKBDMAALDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private LMKDFJAOCFI JBOHBPKJGPL;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool NECDMOCNNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9CBEE0", Offset = "0x9CB2E0", VA = "0x1809CBEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort DECFPHIKHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4A68190", Offset = "0x4A67590", VA = "0x184A68190")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A68180", Offset = "0x4A67580", VA = "0x184A68180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort LPBOHNNEFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4A678D0", Offset = "0x4A66CD0", VA = "0x184A678D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A678C0", Offset = "0x4A66CC0", VA = "0x184A678C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort PEEEDBBMCND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xD963D0", Offset = "0xD957D0", VA = "0x180D963D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xD964F0", Offset = "0xD958F0", VA = "0x180D964F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort LMGDPJNMLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4A68990", Offset = "0x4A67D90", VA = "0x184A68990")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A689A0", Offset = "0x4A67DA0", VA = "0x184A689A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool AGAAEKNOAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x170D6F0", Offset = "0x170CAF0", VA = "0x18170D6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool CBAEHLPLFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xE658E0", Offset = "0xE64CE0", VA = "0x180E658E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event COFAPHJOHPH FPGMCKNKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A682B0", Offset = "0x4A676B0", VA = "0x184A682B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A688F0", Offset = "0x4A67CF0", VA = "0x184A688F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4A68350", Offset = "0x4A67750", VA = "0x184A68350")]
	private T HKJFDDCEPFI(ushort JPNEJNKHCKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A677F0", Offset = "0x4A66BF0", VA = "0x184A677F0")]
	private T AACOIMIOELI(ushort JPNEJNKHCKH, ushort GBMBBBHIBOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A68880", Offset = "0x4A67C80", VA = "0x184A68880")]
	protected T KPKHNPKJAFG(uint FEONNCJFFMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A689B0", Offset = "0x4A67DB0", VA = "0x184A689B0")]
	protected IMAIBPEBABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4A687D0", Offset = "0x4A67BD0", VA = "0x184A687D0")]
	public void IHHNHHAKILL(ushort PLMAJMIIOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4A68810", Offset = "0x4A67C10", VA = "0x184A68810")]
	public void IHHNHHAKILL(ushort PLMAJMIIOGE, ushort EDJLBMFKOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A686B0", Offset = "0x4A67AB0", VA = "0x184A686B0", Slot = "4")]
	protected virtual void IHHNHHAKILL(uint JKEILBGEHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A678E0", Offset = "0x4A66CE0", VA = "0x184A678E0")]
	protected void BDJGJOECNFH(uint JKEILBGEHDO, uint HNHLKGBFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4A68200", Offset = "0x4A67600", VA = "0x184A68200")]
	protected void FPCPLHCHKMM(ushort JPNEJNKHCKH, ushort GBMBBBHIBOO, T FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A681A0", Offset = "0x4A675A0", VA = "0x184A681A0")]
	private void FJJINOJKPNM(uint FEONNCJFFMI, T FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A68410", Offset = "0x4A67810", VA = "0x184A68410")]
	protected void IAFNEELAJAN(float KMHBKELIILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A686A0", Offset = "0x4A67AA0", VA = "0x184A686A0")]
	protected uint IBHJEOCBIMA(ushort JPNEJNKHCKH, ushort GBMBBBHIBOO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A688E0", Offset = "0x4A67CE0", VA = "0x184A688E0")]
	protected ushort LHPPEHPAOPM(uint BFFJPCDHELK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A68870", Offset = "0x4A67C70", VA = "0x184A68870")]
	protected ushort KEJFAAHDCEE(uint BFFJPCDHELK)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class OEDAFPDJDFM : IMAIBPEBABC<OEDAFPDJDFM.OJJJGKMKBNF>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class OJJJGKMKBNF : AKLGDBBCEJF
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ALKODCCDJJD AOPPDDNCBON
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public ALKODCCDJJD DJKEFFIDPNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public LMKDFJAOCFI AKEELCJADEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OJJJGKMKBNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4F90", Offset = "0x7AC4390", VA = "0x187AC4F90")]
	public void NLNGMJECKLG(ushort DCKIDDHNLHC, ALKODCCDJJD FONMALOKECH, ALKODCCDJJD JIANHAHPBFC, LMKDFJAOCFI HNANHEEGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5070", Offset = "0x7AC4470", VA = "0x187AC5070")]
	public void NLNGMJECKLG(ushort JPNEJNKHCKH, ushort GBMBBBHIBOO, ALKODCCDJJD FONMALOKECH, ALKODCCDJJD JIANHAHPBFC, LMKDFJAOCFI HNANHEEGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4F40", Offset = "0x7AC4340", VA = "0x187AC4F40")]
	public void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4510", Offset = "0x7AC3910", VA = "0x187AC4510")]
	protected OEDAFPDJDFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class NCBMKNMEOGG : OEDAFPDJDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool IPHKKJNBPKG;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool PJBCMDOMBND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBEB250", Offset = "0xBEA650", VA = "0x180BEB250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCB8310", Offset = "0xCB7710", VA = "0x180CB8310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AC44B0", Offset = "0x7AC38B0", VA = "0x187AC44B0")]
	public void ENMMELFAOHH(ushort LPNLPNGHAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4450", Offset = "0x7AC3850", VA = "0x187AC4450")]
	public void ENMMELFAOHH(ushort LPNLPNGHAEE, ushort IBLPMCAOCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4510", Offset = "0x7AC3910", VA = "0x187AC4510")]
	public NCBMKNMEOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class LDPMAIFACLE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class PPJEHEDPBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode KBBJDOAJMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode GEFLCBDBKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MADHGAMNHMF BAENOJENPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<MADHGAMNHMF> PIHBPDHCEEH;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PPJEHEDPBDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct MADHGAMNHMF : IComparable<MADHGAMNHMF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int CBJBMBLMJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant PGNBJJMNICE;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x15CFB00", Offset = "0x15CEF00", VA = "0x1815CFB00")]
		public MADHGAMNHMF(int CBJBMBLMJFG, TClaimant PGNBJJMNICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x509F260", Offset = "0x509E660", VA = "0x18509F260")]
		public bool HGJNADJJJKG([In] MADHGAMNHMF DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x509F2C0", Offset = "0x509E6C0", VA = "0x18509F2C0")]
		public bool NEOOOPFLJLL([In] MADHGAMNHMF DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x509F250", Offset = "0x509E650", VA = "0x18509F250", Slot = "4")]
		public int CompareTo(MADHGAMNHMF DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x509F2D0", Offset = "0x509E6D0", VA = "0x18509F2D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum NMMLFEDLNDA
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class NBGOGMMCNPJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public LDPMAIFACLE<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public NBGOGMMCNPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5156640", Offset = "0x5155A40", VA = "0x185156640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5156820", Offset = "0x5155C20", VA = "0x185156820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5156720", Offset = "0x5155B20", VA = "0x185156720", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x47F4C80", Offset = "0x47F4080", VA = "0x1847F4C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly FMGMEFJMHDH<PPJEHEDPBDI> DBICCPCPKII;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly FMGMEFJMHDH<List<MADHGAMNHMF>> PIIHNPNANML;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int LJPAPEBPCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> NPGAEODDLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, PPJEHEDPBDI> JKOIHEHMNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NMMLFEDLNDA FDNGPAPMHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FALGGLALAHL(TNode HAIECNDMOKO);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MONHGEGGGCN(TNode HAIECNDMOKO, TClaimant NMEIMDKELKA, TClaimant NLJKDDAJFBO);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E925A0", Offset = "0x4E919A0", VA = "0x184E925A0")]
	public LDPMAIFACLE(NMMLFEDLNDA FDNGPAPMHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E91310", Offset = "0x4E90710", VA = "0x184E91310")]
	public void FOIGNJCAGLO(TNode HAIECNDMOKO, TNode EEKCDPNNHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E92000", Offset = "0x4E91400", VA = "0x184E92000")]
	public void MKECILMBBEP(TClaimant PGNBJJMNICE, TNode KKHIHBBDJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E90E90", Offset = "0x4E90290", VA = "0x184E90E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E921A0", Offset = "0x4E915A0", VA = "0x184E921A0")]
	private void NCHGLEDOAKN(TClaimant PGNBJJMNICE, TNode IDAMEHEPDOM, TNode KKHIHBBDJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E912A0", Offset = "0x4E906A0", VA = "0x184E912A0")]
	private int FKNEKEBLEPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E91710", Offset = "0x4E90B10", VA = "0x184E91710")]
	private void HDFPGCDHMMI(TClaimant PGNBJJMNICE, TNode OKPHALFBOPA, TNode KOEBAIBFAFB, int PLAGALDLOJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E911C0", Offset = "0x4E905C0", VA = "0x184E911C0")]
	private void EILLOBMJFEC(MADHGAMNHMF HKNDKBLGJHG, PPJEHEDPBDI JBBAONHBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E91B90", Offset = "0x4E90F90", VA = "0x184E91B90")]
	private void LKILPEHEHIM(TClaimant PGNBJJMNICE, TNode OKPHALFBOPA, TNode KOEBAIBFAFB, int PLAGALDLOJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E92270", Offset = "0x4E91670", VA = "0x184E92270")]
	private void NNKHFCNGEGB(MADHGAMNHMF HKNDKBLGJHG, TNode HAIECNDMOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E90", Offset = "0x4E91290", VA = "0x184E91E90")]
	private void LLAJFHDFPJK(MADHGAMNHMF HKNDKBLGJHG, PPJEHEDPBDI JBBAONHBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4E915B0", Offset = "0x4E909B0", VA = "0x184E915B0")]
	private void HAGAGPDPMEF(PPJEHEDPBDI JBBAONHBPHP, bool IHEJCFJOKNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4E90970", Offset = "0x4E8FD70", VA = "0x184E90970")]
	private void BPODAIKKEAP(PPJEHEDPBDI JBBAONHBPHP, TNode EEKCDPNNHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4E910C0", Offset = "0x4E904C0", VA = "0x184E910C0")]
	[IteratorStateMachine(typeof(LDPMAIFACLE<, >.NBGOGMMCNPJ))]
	private IEnumerable<TNode> EADIJALGDJP(TNode OKPHALFBOPA, TNode KOEBAIBFAFB, bool MKJCGCFJBNI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4E91A70", Offset = "0x4E90E70", VA = "0x184E91A70")]
	private PPJEHEDPBDI IEDENFPFEFO(TNode HAIECNDMOKO, TNode GEFLCBDBKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4E90D00", Offset = "0x4E90100", VA = "0x184E90D00")]
	private PPJEHEDPBDI COOBICOFGNM(TNode HAIECNDMOKO, TNode GEFLCBDBKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4E913E0", Offset = "0x4E907E0", VA = "0x184E913E0")]
	private void GNAIJBJLGBA(PPJEHEDPBDI JBBAONHBPHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CBKOPHALCHB<T> : IEnumerable<CBKOPHALCHB<T>.MLKLGADINHH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct MLKLGADINHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T OOEMJLHLIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int COPLIEINKOF;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class BFAGFFBBJON : IEnumerator<MLKLGADINHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private CBKOPHALCHB<T> PPJCHOKILKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int COPLIEINKOF;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x43C34F0", Offset = "0x43C28F0", VA = "0x1843C34F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public MLKLGADINHH CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x5F901A0", Offset = "0x5F8F5A0", VA = "0x185F901A0", Slot = "4")]
			get
			{
				return default(MLKLGADINHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5F90160", Offset = "0x5F8F560", VA = "0x185F90160")]
		public BFAGFFBBJON(CBKOPHALCHB<T> PPJCHOKILKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5F900E0", Offset = "0x5F8F4E0", VA = "0x185F900E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4425700", Offset = "0x4424B00", VA = "0x184425700", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x10CF690", Offset = "0x10CEA90", VA = "0x1810CF690", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct KKNAKCEGKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool HPKEGLPKKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T OOEMJLHLIHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int JHILHCOFMAK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> LOOMBMPJKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private KKNAKCEGKJG[] CCOJEADOLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int JEMCLNLPBJI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int JBBLLKIBLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xCD7890", Offset = "0xCD6C90", VA = "0x180CD7890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xEBE7C0", Offset = "0xEBDBC0", VA = "0x180EBE7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F693A0", Offset = "0x3F687A0", VA = "0x183F693A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x645E8B0", Offset = "0x645DCB0", VA = "0x18645E8B0")]
	public CBKOPHALCHB(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x645E9A0", Offset = "0x645DDA0", VA = "0x18645E9A0")]
	public CBKOPHALCHB(MLKLGADINHH[] FHBFFBMCLHI, bool DHPKPDONNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x645D730", Offset = "0x645CB30", VA = "0x18645D730")]
	public int FFIFIFJEGAF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x645DB90", Offset = "0x645CF90", VA = "0x18645DB90")]
	private int IJEDMHNCHHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x645D610", Offset = "0x645CA10", VA = "0x18645D610", Slot = "6")]
	protected virtual uint DGDNNFCMOCD(uint MKLCJOILBMP, T OOEMJLHLIHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x645D860", Offset = "0x645CC60", VA = "0x18645D860")]
	public bool GCHCFBPMOIA(T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x645D580", Offset = "0x645C980", VA = "0x18645D580")]
	public int BNJFDGPNNBB(T OOEMJLHLIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x645D670", Offset = "0x645CA70", VA = "0x18645D670")]
	public T EJGBPDLFOAE(int COPLIEINKOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x645DDD0", Offset = "0x645D1D0", VA = "0x18645DDD0")]
	public bool KGNGOCHPJJM(T OOEMJLHLIHJ, bool EHKOPDFKCFP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x645DE40", Offset = "0x645D240", VA = "0x18645DE40")]
	public bool KGNGOCHPJJM(T OOEMJLHLIHJ, int COPLIEINKOF, bool EHKOPDFKCFP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x645D910", Offset = "0x645CD10", VA = "0x18645D910")]
	private int HAFFBGPNDKM(int NHKONNPHPEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x645E3C0", Offset = "0x645D7C0", VA = "0x18645E3C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x645E3C0", Offset = "0x645D7C0", VA = "0x18645E3C0", Slot = "4")]
	private IEnumerator<MLKLGADINHH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FMGMEFJMHDH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> CJKIKLHHFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> LEPFGPJJLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int EAODDAFDOGA;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x47EE0B0", Offset = "0x47ED4B0", VA = "0x1847EE0B0")]
	public static FMGMEFJMHDH<T> PADJIFLNODA(int NPKCINNDJFE = 0, int EAODDAFDOGA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x47EDDB0", Offset = "0x47ED1B0", VA = "0x1847EDDB0")]
	public static FMGMEFJMHDH<T> MEGAFDIDCNC(int NPKCINNDJFE = 0, int EAODDAFDOGA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x47EE1B0", Offset = "0x47ED5B0", VA = "0x1847EE1B0")]
	public FMGMEFJMHDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x47EE200", Offset = "0x47ED600", VA = "0x1847EE200")]
	public FMGMEFJMHDH(int NPKCINNDJFE, int EAODDAFDOGA = int.MaxValue, bool OBIGCCLLEMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x47EDB80", Offset = "0x47ECF80", VA = "0x1847EDB80")]
	public T GEKLKKKAMOM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x47ED800", Offset = "0x47ECC00", VA = "0x1847ED800")]
	public void AOLPCAOCNBA(T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x47EDA80", Offset = "0x47ECE80", VA = "0x1847EDA80")]
	private void FCOCBBPGGFB(T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x47EDD60", Offset = "0x47ED160", VA = "0x1847EDD60")]
	private void HKIPEDOMPLN(T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x47ED8F0", Offset = "0x47ECCF0", VA = "0x1847ED8F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x47EDEB0", Offset = "0x47ED2B0", VA = "0x1847EDEB0")]
	private void NCDECBFGGGB(IEnumerable<T> LMNAOMMMDJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PIBNEJILBCB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> CGCBFDCMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T DCFLJKHABIF;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T MDGIMNKKPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x54A4F70", Offset = "0x54A4370", VA = "0x1854A4F70")]
	public bool NHKFLJLIHMM(T OOEMJLHLIHJ, int CBJBMBLMJFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x50DE1D0", Offset = "0x50DD5D0", VA = "0x1850DE1D0")]
	public bool KGLIOHALILA(int CBJBMBLMJFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x54A4B40", Offset = "0x54A3F40", VA = "0x1854A4B40")]
	public T INABNFDNDFP(int OEPNHBGDFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x54A4D60", Offset = "0x54A4160", VA = "0x1854A4D60")]
	private bool LNOJLCBDEFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x54A48A0", Offset = "0x54A3CA0", VA = "0x1854A48A0")]
	public bool EHIFOHHFDPG(int CBJBMBLMJFG, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x54A50D0", Offset = "0x54A44D0", VA = "0x1854A50D0")]
	public PIBNEJILBCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class NFMFPHKIDCL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct LOHLILBEHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T APFNDOMNAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int NFKAMDDPDBK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<LOHLILBEHJO> ILHAEJGFKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T IAECAAEEGNE;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3F693A0", Offset = "0x3F687A0", VA = "0x183F693A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5197540", Offset = "0x5196940", VA = "0x185197540")]
	public bool HEMHPGJLPIO(T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5197160", Offset = "0x5196560", VA = "0x185197160")]
	public void FGAAHPGCDNG(T OOEMJLHLIHJ, int CBJBMBLMJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5197940", Offset = "0x5196D40", VA = "0x185197940")]
	public bool NMPKBAOEGPN(T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5196FD0", Offset = "0x51963D0", VA = "0x185196FD0")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5196E90", Offset = "0x5196290", VA = "0x185196E90")]
	public T BENIBHKEGFO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x51973B0", Offset = "0x51967B0", VA = "0x1851973B0")]
	protected void GEIDEPMLKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5197CE0", Offset = "0x51970E0", VA = "0x185197CE0")]
	public NFMFPHKIDCL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5440", Offset = "0x7AC4840", VA = "0x187AC5440")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5710", Offset = "0x7AC4B10", VA = "0x187AC5710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5620", Offset = "0x7AC4A20", VA = "0x187AC5620")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5390", Offset = "0x7AC4790", VA = "0x187AC5390")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5660", Offset = "0x7AC4A60", VA = "0x187AC5660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7AC5570", Offset = "0x7AC4970", VA = "0x187AC5570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5300", Offset = "0x7AC4700", VA = "0x187AC5300")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x56A1FB0", Offset = "0x56A13B0", VA = "0x1856A1FB0", Slot = "4")]
		public virtual T PDHPIOEJCNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class CDIIPAJNHGG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, KEMPAJDKOFD> ADAJGOKCCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly FMGMEFJMHDH<KEMPAJDKOFD> EJDFLMECHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool BJJIFPCGNKJ;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KEMPAJDKOFD MCDOMCJNBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 ALAJOIMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x152FF10", Offset = "0x152F310", VA = "0x18152FF10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC35DD0", Offset = "0xC351D0", VA = "0x180C35DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 BJHKCMIBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xC628F0", Offset = "0xC61CF0", VA = "0x180C628F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 OMODGEDGADM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2C40", Offset = "0x7AC2040", VA = "0x187AC2C40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9470", Offset = "0x9C8870", VA = "0x1809C9470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int NHJOPECCOME
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9640", Offset = "0x9D8A40", VA = "0x1809D9640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9630", Offset = "0x9D8A30", VA = "0x1809D9630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3080", Offset = "0x7AC2480", VA = "0x187AC3080")]
	public CDIIPAJNHGG(Bounds LFAGNKPCDEM, Vector2[] JCJADFGHNAI, int MDPCLCNDMML, byte NHKONNPHPEL, float EDHLAOPMECB = 0f, [Optional] FMGMEFJMHDH<KEMPAJDKOFD> EJDFLMECHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC27B0", Offset = "0x7AC1BB0", VA = "0x187AC27B0")]
	public void HOPOBLMPFMD(Bounds LFAGNKPCDEM, Vector2[] JCJADFGHNAI, int MDPCLCNDMML, byte NHKONNPHPEL, float EDHLAOPMECB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3020", Offset = "0x7AC2420", VA = "0x187AC3020")]
	public KEMPAJDKOFD OCMMGIDAOPK(byte COPLIEINKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7AC20D0", Offset = "0x7AC14D0", VA = "0x187AC20D0")]
	public void BDKMPKGMEKN(Vector3 KBPOHLLNAIG, float JOAGLNLMJOE, float KJCLJKNKLIH, List<byte> OBHONNNNEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7AC21A0", Offset = "0x7AC15A0", VA = "0x187AC21A0")]
	public void DBIIBGMIEIN(KEMPAJDKOFD.CKMIOBHODAI FKCIKGJOCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7AC24B0", Offset = "0x7AC18B0", VA = "0x187AC24B0")]
	public static int GLPIAEEKJID(Vector2[] JCJADFGHNAI, int MDPCLCNDMML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2220", Offset = "0x7AC1620", VA = "0x187AC2220")]
	private KEMPAJDKOFD FPLFGIFBAHB(byte COPLIEINKOF, KEMPAJDKOFD.ALMHPOOPMLP EPNAHBJKNKO, KEMPAJDKOFD GEFLCBDBKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2C60", Offset = "0x7AC2060", VA = "0x187AC2C60")]
	private void JOBKLBINOED(KEMPAJDKOFD GEFLCBDBKHP, Vector2[] JCJADFGHNAI, int FGGGADEAIKH, int HFBPMHLDLAG, int JHOPMDILJKC, int PILFANNKLON, float EDHLAOPMECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2590", Offset = "0x7AC1990", VA = "0x187AC2590")]
	private void GNPEGCMHFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7AC21C0", Offset = "0x7AC15C0", VA = "0x187AC21C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2450", Offset = "0x7AC1850", VA = "0x187AC2450", Slot = "1")]
	~CDIIPAJNHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class KEMPAJDKOFD
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum ALMHPOOPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum CKMIOBHODAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte NKGPMMKCOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 PPFHOKPGGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 JFMOMNOKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 ADEMADAODLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 HDMLKPGGFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public ALMHPOOPMLP KHELDMFBGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public KEMPAJDKOFD KCNKMLOKLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<KEMPAJDKOFD> CGCBKHDIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool BGNINLALFIM;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4430", Offset = "0x7AC3830", VA = "0x187AC4430")]
	public KEMPAJDKOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC42C0", Offset = "0x7AC36C0", VA = "0x187AC42C0")]
	public void IJGKMPINBMM(KEMPAJDKOFD EDKEHABGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public void DBIIBGMIEIN(int CDEPHFPLIPM, CKMIOBHODAI FKCIKGJOCPB, int FNGDFPLAMIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3FA0", Offset = "0x7AC33A0", VA = "0x187AC3FA0")]
	public void BDKMPKGMEKN(List<byte> OBHONNNNEAN, Vector3 KBPOHLLNAIG, float JOAGLNLMJOE, float KJCLJKNKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4290", Offset = "0x7AC3690", VA = "0x187AC4290")]
	public bool GPPMHFLIHBH(Vector3 BCFKCHJBFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4400", Offset = "0x7AC3800", VA = "0x187AC4400")]
	public bool NKCLGFICDKD(Vector3 BCFKCHJBFCG, float NCKLMGKJOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4200", Offset = "0x7AC3600", VA = "0x187AC4200")]
	public void ENMMELFAOHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface BOLONLGCFKI
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache PABIOAAKJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct HCJFOIFLJJM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> ANHMDLEGCDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool FIBMPJCGANO;

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1729F40", Offset = "0x1729340", VA = "0x181729F40")]
			public HCJFOIFLJJM(List<Component> ANHMDLEGCDL, bool FIBMPJCGANO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x49101C0", Offset = "0x490F5C0", VA = "0x1849101C0")]
			public IKEOKLFEPJH<T> PMMOLBDEIOM()
			{
				return default(IKEOKLFEPJH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x4910230", Offset = "0x490F630", VA = "0x184910230", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4910230", Offset = "0x490F630", VA = "0x184910230", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public struct IKEOKLFEPJH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> ANHMDLEGCDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool FIBMPJCGANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int COPLIEINKOF;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T CHOEFFOHNEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4A64EE0", Offset = "0x4A642E0", VA = "0x184A64EE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x4A64E70", Offset = "0x4A64270", VA = "0x184A64E70", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x4A64EB0", Offset = "0x4A642B0", VA = "0x184A64EB0")]
			public IKEOKLFEPJH(List<Component> ANHMDLEGCDL, bool FIBMPJCGANO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4A64DB0", Offset = "0x4A641B0", VA = "0x184A64DB0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x4A64DC0", Offset = "0x4A641C0", VA = "0x184A64DC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x44127B0", Offset = "0x4411BB0", VA = "0x1844127B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7AC7140", Offset = "0x7AC6540", VA = "0x187AC7140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6A20", Offset = "0x7AC5E20", VA = "0x187AC6A20")]
		private void ENMMELFAOHH(GameObject PDHGEEJKEMG, bool IMJBLFBLNHJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6B90", Offset = "0x7AC5F90", VA = "0x187AC6B90")]
		public static void ENMMELFAOHH(GameObject PDHGEEJKEMG, ToolHierarchyCache NMAEEMHJHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7030", Offset = "0x7AC6430", VA = "0x187AC7030")]
		public void GIPMNEBDDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3A489D0", Offset = "0x3A47DD0", VA = "0x183A489D0")]
		public void GIBIFBEINLF<T>(Action<T> PDHMHKIHKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3A48C10", Offset = "0x3A48010", VA = "0x183A48C10")]
		public T JPLCCHLCFIB<T>(bool FIBMPJCGANO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3A48910", Offset = "0x3A47D10", VA = "0x183A48910")]
		public HCJFOIFLJJM<T> FHPDKLALJGN<T>(bool FIBMPJCGANO = false) where T : class
		{
			return default(HCJFOIFLJJM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6CA0", Offset = "0x7AC60A0", VA = "0x187AC6CA0")]
		public List<Component> FFJPBKGOOGK(Type KHNCICOHHHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6C20", Offset = "0x7AC6020", VA = "0x187AC6C20", Slot = "4")]
		public bool Equals(ToolHierarchyCache COBPEJEHIHC, ToolHierarchyCache CEJJJCAALLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7040", Offset = "0x7AC6440", VA = "0x187AC7040", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KLANNNFBLNB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class AJEEICNPPAA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int NPKCINNDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int CPFGBKKIHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> NFMDGGFOHIL;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x47D6970", Offset = "0x47D5D70", VA = "0x1847D6970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T GCFJBIFLLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4BC19D0", Offset = "0x4BC0DD0", VA = "0x184BC19D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T ABKBAKIMLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1AD0", Offset = "0x4BC0ED0", VA = "0x184BC1AD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T HHLIJKJIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1650", Offset = "0x4BC0A50", VA = "0x184BC1650")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1BE0", Offset = "0x4BC0FE0", VA = "0x184BC1BE0")]
	public AJEEICNPPAA(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4BC14D0", Offset = "0x4BC08D0", VA = "0x184BC14D0")]
	public void FGAAHPGCDNG(T FKJNOBCGCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1300", Offset = "0x4BC0700", VA = "0x184BC1300")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1760", Offset = "0x4BC0B60", VA = "0x184BC1760")]
	public void HJCNGHNJFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1290", Offset = "0x4BC0690", VA = "0x184BC1290")]
	public void EFDMBFGOPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1280", Offset = "0x4BC0680", VA = "0x184BC1280")]
	public void COFECKPJBLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1860", Offset = "0x4BC0C60", VA = "0x184BC1860")]
	public List<T> JDICDDLOHHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class HMMMFBEOJDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct FHELNOEFKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int NFKAMDDPDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T APFNDOMNAPN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, FHELNOEFKLC> CGCBFDCMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> ODEEKFLHJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T DCFLJKHABIF;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T MDGIMNKKPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCDBA30", Offset = "0xCDAE30", VA = "0x180CDBA30", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x496B6F0", Offset = "0x496AAF0", VA = "0x18496B6F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HCAOEIALIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x496FDF0", Offset = "0x496F1F0", VA = "0x18496FDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object FJONHIKFFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x496F2B0", Offset = "0x496E6B0", VA = "0x18496F2B0")]
	public bool NHKFLJLIHMM(T OOEMJLHLIHJ, object PAHPIGHLKFG, int CBJBMBLMJFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x496C080", Offset = "0x496B480", VA = "0x18496C080")]
	public bool KGLIOHALILA(object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x496B8C0", Offset = "0x496ACC0", VA = "0x18496B8C0")]
	public bool EHIFOHHFDPG(object PAHPIGHLKFG, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x496C020", Offset = "0x496B420", VA = "0x18496C020")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x496D520", Offset = "0x496C920", VA = "0x18496D520")]
	private bool LNOJLCBDEFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x496FE50", Offset = "0x496F250", VA = "0x18496FE50")]
	public HMMMFBEOJDO()
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
