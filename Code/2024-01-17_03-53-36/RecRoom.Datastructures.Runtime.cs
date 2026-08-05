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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LGENIFOJDPN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	public LGENIFOJDPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, HJKHGLKJOCN, GCCILCGHAMO, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78DFC0", Offset = "0x78CDC0", VA = "0x18078DFC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7919F0", Offset = "0x7907F0", VA = "0x1807919F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NGEJDKKNACK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81B4D0", Offset = "0x81A2D0", VA = "0x18081B4D0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[HLPLBKGLOCB]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HLPLBKGLOCB]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7B80", Offset = "0x5FA6980", VA = "0x185FA7B80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7B40", Offset = "0x5FA6940", VA = "0x185FA7B40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7BC0", Offset = "0x5FA69C0", VA = "0x185FA7BC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7D70", Offset = "0x5FA6B70", VA = "0x185FA7D70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7CE0", Offset = "0x5FA6AE0", VA = "0x185FA7CE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89F230", Offset = "0x89E030", VA = "0x18089F230")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9674F0", Offset = "0x9662F0", VA = "0x1809674F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7B00", Offset = "0x5FA6900", VA = "0x185FA7B00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7C50", Offset = "0x5FA6A50", VA = "0x185FA7C50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7730", Offset = "0x5FA6530", VA = "0x185FA7730")]
	public void CopyBounds(SavedExtents GDMGBCDFBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7A50", Offset = "0x5FA6850", VA = "0x185FA7A50")]
	public void SetLocalSpaceBounds(Bounds MMGLOGJLPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x980420", Offset = "0x97F220", VA = "0x180980420")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7980", Offset = "0x5FA6780", VA = "0x185FA7980")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6F00", Offset = "0x5FA5D00", VA = "0x185FA6F00")]
	private void BDJAGBNKNAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7760", Offset = "0x5FA6560", VA = "0x185FA7760")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA70C0", Offset = "0x5FA5EC0", VA = "0x185FA70C0")]
	public static void CalculateLocalBoundsFor(GameObject FAIKIGMIEFB, [Out] Bounds MMGLOGJLPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7990", Offset = "0x5FA6790", VA = "0x185FA7990")]
	private static void PABCLGGOFHK(Bounds BJNEJGMGENI, Color PPMDGMFKMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7A70", Offset = "0x5FA6870", VA = "0x185FA7A70")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x797AF0", Offset = "0x7968F0", VA = "0x180797AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDA73C0", Offset = "0xDA61C0", VA = "0x180DA73C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x421C550", Offset = "0x421B350", VA = "0x18421C550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "4")]
	public virtual void JKCGEOACAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[LGENIFOJDPN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x421C130", Offset = "0x421AF30", VA = "0x18421C130", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x421ADD0", Offset = "0x4219BD0", VA = "0x18421ADD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x421C480", Offset = "0x421B280", VA = "0x18421C480")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DDIALJMBDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public DDIALJMBDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C3F0", Offset = "0x4F3B1F0", VA = "0x184F3C3F0")]
		internal int GPNJMLBBKJN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[LGENIFOJDPN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32A6150", Offset = "0x32A4F50", VA = "0x1832A6150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32A61A0", Offset = "0x32A4FA0", VA = "0x1832A61A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32A6050", Offset = "0x32A4E50", VA = "0x1832A6050", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey IDGIKKEFDCG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32A60F0", Offset = "0x32A4EF0", VA = "0x1832A60F0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32A5F30", Offset = "0x32A4D30", VA = "0x1832A5F30", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32A5C50", Offset = "0x32A4A50", VA = "0x1832A5C50", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32A50F0", Offset = "0x32A3EF0", VA = "0x1832A50F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32A50C0", Offset = "0x32A3EC0", VA = "0x1832A50C0", Slot = "14")]
	protected virtual string INPJGGFBFPL(TKeyVal BPKHCGGKHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32A4F70", Offset = "0x32A3D70", VA = "0x1832A4F70", Slot = "4")]
	public bool ContainsKey(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32A5DF0", Offset = "0x32A4BF0", VA = "0x1832A5DF0", Slot = "5")]
	public bool TryGetValue(TKey IDGIKKEFDCG, [Out] TVal MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32A4FC0", Offset = "0x32A3DC0", VA = "0x1832A4FC0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32A4FC0", Offset = "0x32A3DC0", VA = "0x1832A4FC0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32A5E40", Offset = "0x32A4C40", VA = "0x1832A5E40")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JCBPHJBCKLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CPABAHNEEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public CPABAHNEEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9200", Offset = "0x4BA8000", VA = "0x184BA9200")]
		internal bool OEKKGCONPEE(GMBHMAMMDKO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float APJHDKGPHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float IAIGDGCKHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<GMBHMAMMDKO<float, T>> FEOLAGHNDGI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PFEDJMAJDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39A64F0", Offset = "0x39A52F0", VA = "0x1839A64F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39A65D0", Offset = "0x39A53D0", VA = "0x1839A65D0")]
	public JCBPHJBCKLN(float JDNGOFPDEIH, float NKFCDIBNODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39A5C30", Offset = "0x39A4A30", VA = "0x1839A5C30")]
	public bool BKAEIPDDPKF(float HKAMOIHPHHI, T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x39A5EA0", Offset = "0x39A4CA0", VA = "0x1839A5EA0")]
	public IEnumerable<T> IJDJMHKCCHH(float HKAMOIHPHHI, [Optional] float? MEPDCGMCGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39A64C0", Offset = "0x39A52C0", VA = "0x1839A64C0")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39A5DC0", Offset = "0x39A4BC0", VA = "0x1839A5DC0")]
	private void HIKMFAPJENA(float HKAMOIHPHHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JDKBMPEJKDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LCMOOMLIIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T AOJPLLHPPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float KKHDODLOEDN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float NCELMMIDNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> HCGGHODBKII;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int BNCDAFHEJPH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private LCMOOMLIIJM[] IPODKPLEDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int GLIHOMNMNHD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ABPOPCEDCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB5D800", Offset = "0xB5C600", VA = "0x180B5D800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB5D7E0", Offset = "0xB5C5E0", VA = "0x180B5D7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39A9380", Offset = "0x39A8180", VA = "0x1839A9380")]
	public JDKBMPEJKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39A9290", Offset = "0x39A8090", VA = "0x1839A9290")]
	public JDKBMPEJKDP(int GENDLFFGOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39A8800", Offset = "0x39A7600", VA = "0x1839A8800")]
	public void EHPBILHDFGD(float HKAMOIHPHHI, T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39A8BD0", Offset = "0x39A79D0", VA = "0x1839A8BD0")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39A8DB0", Offset = "0x39A7BB0", VA = "0x1839A8DB0")]
	public bool LLDNEDGKHAE(float LFFDKFDIBNB, float FILJPFPCDOD, [Out] T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x39A83B0", Offset = "0x39A71B0", VA = "0x1839A83B0")]
	public bool BGCEMFIGGBN(float LFFDKFDIBNB, float FILJPFPCDOD, [Out] T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x39A8A90", Offset = "0x39A7890", VA = "0x1839A8A90")]
	public void JJOOMJBFNHN(float LFFDKFDIBNB, float FILJPFPCDOD, List<T> FHEAENNOLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39A8910", Offset = "0x39A7710", VA = "0x1839A8910")]
	private int JJMAGADLINL(int ODGJCHOHEJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x39A88C0", Offset = "0x39A76C0", VA = "0x1839A88C0")]
	private void FGPOEICPKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MEKNGNLMHEN();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BGCNJMLAGLK(T MBDKMNBCLGF, float LNJHGKLPHDO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LGLHJKJDHHI(T LBKCGMCBJAD, T LEFACNCEBHI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T AIBMHPOPIMM(T LBKCGMCBJAD, T LEFACNCEBHI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KDHNBGGOEAE : JDKBMPEJKDP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79E990", Offset = "0x79D790", VA = "0x18079E990", Slot = "4")]
	protected override Vector3 MEKNGNLMHEN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6840", Offset = "0x5FA5640", VA = "0x185FA6840", Slot = "5")]
	protected override Vector3 BGCNJMLAGLK(Vector3 MBDKMNBCLGF, float LNJHGKLPHDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6880", Offset = "0x5FA5680", VA = "0x185FA6880", Slot = "6")]
	protected override Vector3 LGLHJKJDHHI(Vector3 LBKCGMCBJAD, Vector3 LEFACNCEBHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FA67C0", Offset = "0x5FA55C0", VA = "0x185FA67C0", Slot = "7")]
	protected override Vector3 AIBMHPOPIMM(Vector3 LBKCGMCBJAD, Vector3 LEFACNCEBHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FA68D0", Offset = "0x5FA56D0", VA = "0x185FA68D0")]
	public KDHNBGGOEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IMIEOPHKNCA
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25EBE40", Offset = "0x25EAC40", VA = "0x1825EBE40")]
	public static GMBHMAMMDKO<T1, T2> KCGHAKHJLMB<T1, T2>(T1 NMNGHNFAANH, T2 IFIGPJFFEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25EBEC0", Offset = "0x25EACC0", VA = "0x1825EBEC0")]
	public static MPGGCICLBDB<T1, T2, T3> KCGHAKHJLMB<T1, T2, T3>(T1 NMNGHNFAANH, T2 IFIGPJFFEAL, T3 NMHCCDBBBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEEC0", Offset = "0x3DCDCC0", VA = "0x183DCEEC0")]
	internal static int GJDKPKLBMNJ(int AEIGAJBAILF, int PFFGKMPKLLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x540D910", Offset = "0x540C710", VA = "0x18540D910")]
	internal static int GJDKPKLBMNJ(int AEIGAJBAILF, int PFFGKMPKLLF, int AJAPDFCNIEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GMBHMAMMDKO<T1, T2> : IComparable<GMBHMAMMDKO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 NGFHJAKFKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 FFECMBNNJAE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x36F3890", Offset = "0x36F2690", VA = "0x1836F3890")]
	public GMBHMAMMDKO(T1 NMNGHNFAANH, T2 IFIGPJFFEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36F19F0", Offset = "0x36F07F0", VA = "0x1836F19F0", Slot = "4")]
	public int CompareTo(GMBHMAMMDKO<T1, T2> GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x36F2560", Offset = "0x36F1360", VA = "0x1836F2560", Slot = "0")]
	public override bool Equals(object GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36F2AB0", Offset = "0x36F18B0", VA = "0x1836F2AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x36F34D0", Offset = "0x36F22D0", VA = "0x1836F34D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MPGGCICLBDB<T1, T2, T3> : IComparable<MPGGCICLBDB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 NGFHJAKFKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 FFECMBNNJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 LDDBCEGBCIL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1E70", Offset = "0x3DA0C70", VA = "0x183DA1E70")]
	public MPGGCICLBDB(T1 NMNGHNFAANH, T2 IFIGPJFFEAL, T3 NMHCCDBBBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1670", Offset = "0x3DA0470", VA = "0x183DA1670", Slot = "4")]
	public int CompareTo(MPGGCICLBDB<T1, T2, T3> GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3DA18C0", Offset = "0x3DA06C0", VA = "0x183DA18C0", Slot = "0")]
	public override bool Equals(object GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1B00", Offset = "0x3DA0900", VA = "0x183DA1B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1BA0", Offset = "0x3DA09A0", VA = "0x183DA1BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2013E40", Offset = "0x2012C40", VA = "0x182013E40")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2013C10", Offset = "0x2012A10", VA = "0x182013C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float JNDILHGGFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81B5B0", Offset = "0x81A3B0", VA = "0x18081B5B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4434280", Offset = "0x4433080", VA = "0x184434280")]
	public T OIAGMBEFFDG(float LNJHGKLPHDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4433F20", Offset = "0x4432D20", VA = "0x184433F20")]
	public T IMJGCHOOAAM(float LNJHGKLPHDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GPAHCCDLKKL(T LBKCGMCBJAD, T LEFACNCEBHI, float LNJHGKLPHDO);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5140", Offset = "0x5FA3F40", VA = "0x185FA5140", Slot = "4")]
	protected override float GPAHCCDLKKL(float LBKCGMCBJAD, float LEFACNCEBHI, float LNJHGKLPHDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5180", Offset = "0x5FA3F80", VA = "0x185FA5180")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC5D980", Offset = "0xC5C780", VA = "0x180C5D980", Slot = "4")]
	protected override Vector3 GPAHCCDLKKL(Vector3 LBKCGMCBJAD, Vector3 LEFACNCEBHI, float LNJHGKLPHDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8A80", Offset = "0x5FA7880", VA = "0x185FA8A80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3C30", Offset = "0x5FA2A30", VA = "0x185FA3C30", Slot = "4")]
	protected override Color GPAHCCDLKKL(Color LBKCGMCBJAD, Color LEFACNCEBHI, float LNJHGKLPHDO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3CF0", Offset = "0x5FA2AF0", VA = "0x185FA3CF0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GFNIJGJNNJO : CABGHLGJEPD<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5230", Offset = "0x5FA4030", VA = "0x185FA5230")]
	public GFNIJGJNNJO(int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FA51C0", Offset = "0x5FA3FC0", VA = "0x185FA51C0", Slot = "6")]
	protected override uint FEGMMPKGEBJ(uint NGEJDKKNACK, string MBDKMNBCLGF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CHLDONBGJNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable CEIKCOHBGGB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public CHLDONBGJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BHPNMEGNNIC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CCJCOCAGKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HMGAELNEEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int INGDJKKDGFG;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D11120", Offset = "0x1D0FF20", VA = "0x181D11120")]
	private BHPNMEGNNIC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PKOJJGBCJLM, int DAOKHGGKBJC, int AEKEDGJHFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x46A8900", Offset = "0x46A7700", VA = "0x1846A8900")]
	public static BHPNMEGNNIC<T> DCPHPAHCOGO()
	{
		return default(BHPNMEGNNIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x46A9780", Offset = "0x46A8580", VA = "0x1846A9780")]
	public (int, int, Task<T>) OACGINCPGJA(int DOKAOHMAJKK, [Optional] CancellationToken EHAEIHNIHFM, double JILOLFHINNI = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x46A8710", Offset = "0x46A7510", VA = "0x1846A8710")]
	public void AJODEEBCALG(int DOKAOHMAJKK, int AEKEDGJHFDK, [In] T ADPBDOHMAGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IJPDJAJEAIK
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA60F0", Offset = "0x5FA4EF0", VA = "0x185FA60F0")]
	public static BHPNMEGNNIC<BCBPFABBCDG> DCPHPAHCOGO()
	{
		return default(BHPNMEGNNIC<BCBPFABBCDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6070", Offset = "0x5FA4E70", VA = "0x185FA6070")]
	public static void AJODEEBCALG([In] this BHPNMEGNNIC<BCBPFABBCDG> OJFDNDCDDBK, int DOKAOHMAJKK, int AEKEDGJHFDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class LPLAKEEEEEM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> GMCFMCGHBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> DIHNAOEAJNL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x305E230", Offset = "0x305D030", VA = "0x18305E230", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool CEHPCHNOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> BFFKJKEDGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x36C45A0", Offset = "0x36C33A0", VA = "0x1836C45A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> LBJKKGJMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3B81F40", Offset = "0x3B80D40", VA = "0x183B81F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3B81EE0", Offset = "0x3B80CE0", VA = "0x183B81EE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B81FA0", Offset = "0x3B80DA0", VA = "0x183B81FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B818C0", Offset = "0x3B806C0", VA = "0x183B818C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B81200", Offset = "0x3B80000", VA = "0x183B81200", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B81C70", Offset = "0x3B80A70", VA = "0x183B81C70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B811D0", Offset = "0x3B7FFD0", VA = "0x183B811D0", Slot = "9")]
	public void Add(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B81160", Offset = "0x3B7FF60", VA = "0x183B81160", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A4BBA0", Offset = "0x3A4A9A0", VA = "0x183A4BBA0", Slot = "8")]
	public bool ContainsKey(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B812C0", Offset = "0x3B800C0", VA = "0x183B812C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B81C10", Offset = "0x3B80A10", VA = "0x183B81C10", Slot = "10")]
	public bool Remove(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B81C40", Offset = "0x3B80A40", VA = "0x183B81C40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B81D60", Offset = "0x3B80B60", VA = "0x183B81D60", Slot = "11")]
	public bool TryGetValue(TKey IDGIKKEFDCG, [Out] TVal MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B81370", Offset = "0x3B80170", VA = "0x183B81370", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B812F0", Offset = "0x3B800F0", VA = "0x183B812F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IPODKPLEDFE, int BKFPMJOKOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3B81870", Offset = "0x3B80670", VA = "0x183B81870")]
	public bool JPCECNBPLDE(TVal IDGIKKEFDCG, [Out] TKey MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B81780", Offset = "0x3B80580", VA = "0x183B81780")]
	private void IJFPLDMFNMJ(TKey IDGIKKEFDCG, TVal AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B815C0", Offset = "0x3B803C0", VA = "0x183B815C0")]
	private void IGJIMKFMOHH(TKey IDGIKKEFDCG, TVal AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B81B00", Offset = "0x3B80900", VA = "0x183B81B00")]
	private bool PAGDEKCFJJN(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B81DA0", Offset = "0x3B80BA0", VA = "0x183B81DA0")]
	public LPLAKEEEEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class BGMLPEPJKEF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BGMLPEPJKEF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x32EE5F0", Offset = "0x32ED3F0", VA = "0x1832EE5F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x32FA650", Offset = "0x32F9450", VA = "0x1832FA650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x32FB2A0", Offset = "0x32FA0A0", VA = "0x1832FB2A0")]
		public Enumerator(BGMLPEPJKEF<T> FHEAENNOLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x32F8F20", Offset = "0x32F7D20", VA = "0x1832F8F20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x32F9DE0", Offset = "0x32F8BE0", VA = "0x1832F9DE0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x32F8A60", Offset = "0x32F7860", VA = "0x1832F8A60")]
		private void MLDNMAECJGJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] MLGEHMMCOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int MIMLCMKCBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HFBFLHDPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int ECDEHLGBDJN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4697560", Offset = "0x4696360", VA = "0x184697560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4698770", Offset = "0x4697570", VA = "0x184698770")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4697310", Offset = "0x4696110", VA = "0x184697310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4698BB0", Offset = "0x46979B0", VA = "0x184698BB0")]
	public BGMLPEPJKEF(int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4697730", Offset = "0x4696530", VA = "0x184697730")]
	public void EHPBILHDFGD(T LNJHGKLPHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4698700", Offset = "0x4697500", VA = "0x184698700")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4698100", Offset = "0x4696F00", VA = "0x184698100")]
	public void HADCIDLLHCH(int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4697B40", Offset = "0x4696940", VA = "0x184697B40")]
	public void FBLCAEPFLLJ(T[] IPODKPLEDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x46972A0", Offset = "0x46960A0", VA = "0x1846972A0")]
	public Enumerator BCGCEOCJJAB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x46989F0", Offset = "0x46977F0", VA = "0x1846989F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46989F0", Offset = "0x46977F0", VA = "0x1846989F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x46983D0", Offset = "0x46971D0", VA = "0x1846983D0")]
	private int IKCNBMAFPKG(int HPLKFBKKIBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4698940", Offset = "0x4697740", VA = "0x184698940")]
	private int OFAAMMCEMMC(int HPLKFBKKIBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class OBHCNDLIJGN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> AIDJPPAEJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> HFLDOAFOIEF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4280", Offset = "0x3ED3080", VA = "0x183ED4280", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4230", Offset = "0x3ED3030", VA = "0x183ED4230", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public OBHCNDLIJGN(Func<Internal, External> AIDJPPAEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3ED41E0", Offset = "0x3ED2FE0", VA = "0x183ED41E0")]
	public OBHCNDLIJGN(IReadOnlyList<Internal> HFLDOAFOIEF, Func<Internal, External> AIDJPPAEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4160", Offset = "0x3ED2F60", VA = "0x183ED4160", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x34BDA90", Offset = "0x34BC890", VA = "0x1834BDA90", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HOAPGPFCNAJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> GOBCIFLJBOP(TRequest NNOFNOIFPML, CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum IFCINDBJFDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GLDONEAKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float OOJHEJNFMBG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan MIOPKNIJAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int OMLNKGIIAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IFCINDBJFDM CLINIPPFOKN;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly GLDONEAKDMO DOPLKALBEDL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float HLKGMIKCDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x36F0D70", Offset = "0x36EFB70", VA = "0x1836F0D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LIDBGBGJAOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x36F0E50", Offset = "0x36EFC50", VA = "0x1836F0E50")]
		public GLDONEAKDMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct EJIEPAKLJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest NNOFNOIFPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken EHAEIHNIHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> GIGBONOOALE;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3250320", Offset = "0x324F120", VA = "0x183250320")]
		public EJIEPAKLJEE(TRequest NNOFNOIFPML, TaskCompletionSource<TResult> GIGBONOOALE, CancellationToken EHAEIHNIHFM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct MPKEGPLDDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HOAPGPFCNAJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6A40", Offset = "0x3DA5840", VA = "0x183DA6A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7640", Offset = "0x3DA6440", VA = "0x183DA7640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BBECHBEPOAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public HOAPGPFCNAJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EJIEPAKLJEE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4661080", Offset = "0x465FE80", VA = "0x184661080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x46616E0", Offset = "0x46604E0", VA = "0x1846616E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource JCEKDEAGDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<EJIEPAKLJEE> LHMINFNNEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GLDONEAKDMO LLLCJPFOOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GOBCIFLJBOP BKFIDBFGJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task IGLFFOEPJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int MMLLPDKIHEC;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x375DAB0", Offset = "0x375C8B0", VA = "0x18375DAB0")]
	public HOAPGPFCNAJ(GOBCIFLJBOP BKFIDBFGJHG, [Optional] GLDONEAKDMO LLLCJPFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x375C360", Offset = "0x375B160", VA = "0x18375C360")]
	public Task<TResult> HEHOELENNPN(TRequest NNOFNOIFPML, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x375D5B0", Offset = "0x375C3B0", VA = "0x18375D5B0")]
	private void OEDNDMKNBGE(EJIEPAKLJEE KOIGLJCKKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x375D390", Offset = "0x375C190", VA = "0x18375D390")]
	[AsyncStateMachine(typeof(HOAPGPFCNAJ<, >.MPKEGPLDDCK))]
	private Task NMFNMJAAKOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x375C9E0", Offset = "0x375B7E0", VA = "0x18375C9E0")]
	private EJIEPAKLJEE HPILIGCMMGI()
	{
		return default(EJIEPAKLJEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x375D750", Offset = "0x375C550", VA = "0x18375D750")]
	[AsyncStateMachine(typeof(HOAPGPFCNAJ<, >.BBECHBEPOAI))]
	private Task OHMOIPPDPGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x375D010", Offset = "0x375BE10", VA = "0x18375D010")]
	private void JIGAGPHLPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x375C0D0", Offset = "0x375AED0", VA = "0x18375C0D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class HCGLBAADGEJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> HFLDOAFOIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> LMHANMHBDPA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x305E230", Offset = "0x305D030", VA = "0x18305E230", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CEHPCHNOICL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3732190", Offset = "0x3730F90", VA = "0x183732190", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x37322B0", Offset = "0x37310B0", VA = "0x1837322B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x363DC60", Offset = "0x363CA60", VA = "0x18363DC60", Slot = "11")]
	public void Add(T KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3731940", Offset = "0x3730740", VA = "0x183731940")]
	public bool CJDLFIMGCDM(T KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3732000", Offset = "0x3730E00", VA = "0x183732000", Slot = "15")]
	public bool Remove(T KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3731AD0", Offset = "0x37308D0", VA = "0x183731AD0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x35F1230", Offset = "0x35F0030", VA = "0x1835F1230", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3731A00", Offset = "0x3730800", VA = "0x183731A00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3731A60", Offset = "0x3730860", VA = "0x183731A60", Slot = "13")]
	public bool Contains(T KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3731AA0", Offset = "0x37308A0", VA = "0x183731AA0", Slot = "14")]
	public void CopyTo(T[] IPODKPLEDFE, int BKFPMJOKOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3731B60", Offset = "0x3730960", VA = "0x183731B60", Slot = "6")]
	public int IndexOf(T KMBHPJEIFIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3731BB0", Offset = "0x37309B0", VA = "0x183731BB0", Slot = "7")]
	public void Insert(int HPLKFBKKIBG, T KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3731D70", Offset = "0x3730B70", VA = "0x183731D70", Slot = "8")]
	public void RemoveAt(int HPLKFBKKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x37320A0", Offset = "0x3730EA0", VA = "0x1837320A0")]
	public HCGLBAADGEJ()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E71260", Offset = "0x1E70060", VA = "0x181E71260")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8110", Offset = "0x5FA6F10", VA = "0x185FA8110")]
		public SerializedGuid([In] Guid FILMEIPENDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7F00", Offset = "0x5FA6D00", VA = "0x185FA7F00")]
		public static SerializedGuid FPEKELHJNHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7FF0", Offset = "0x5FA6DF0", VA = "0x185FA7FF0")]
		public static SerializedGuid JJALHLLNMCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7F90", Offset = "0x5FA6D90", VA = "0x185FA7F90")]
		public bool IJDAKCFEOFC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA80E0", Offset = "0x5FA6EE0", VA = "0x185FA80E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8060", Offset = "0x5FA6E60", VA = "0x185FA8060", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7E30", Offset = "0x5FA6C30", VA = "0x185FA7E30", Slot = "7")]
		public bool Equals(SerializedGuid GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7E70", Offset = "0x5FA6C70", VA = "0x185FA7E70", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7F80", Offset = "0x5FA6D80", VA = "0x185FA7F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7E00", Offset = "0x5FA6C00", VA = "0x185FA7E00", Slot = "6")]
		public int CompareTo(SerializedGuid GDMGBCDFBAL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GPGDFABBMMI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type BPEHBALBDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string HNHDKECMDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool NJMFNLIKIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool JOLBKGICEMK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6000", Offset = "0x5FA4E00", VA = "0x185FA6000")]
	public GPGDFABBMMI(Type LIGIGGDKFOL, string LNJFPMMKCIM, bool KOOOAEPFNMF = false, bool JIAADKIBHFG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AGDBIEMPPKH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct KKALGKGLKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long KLCOLNMOBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long ECACALFBNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int BFJKFNKJJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int OPIEJNLPPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool EGFGJNFLDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string DOPKLCALBNL;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA2F0", Offset = "0x3AA90F0", VA = "0x183AAA2F0")]
		public KKALGKGLKNG(long KLCOLNMOBBN, int BFJKFNKJJOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA2C0", Offset = "0x3AA90C0", VA = "0x183AAA2C0")]
		public KKALGKGLKNG(long KLCOLNMOBBN, long ECACALFBNEG, int BFJKFNKJJOK, int OPIEJNLPPJB, bool EGFGJNFLDIG, string DOPKLCALBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA270", Offset = "0x3AA9070", VA = "0x183AAA270")]
		public int KNLNLNCJMDN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA150", Offset = "0x3AA8F50", VA = "0x183AAA150")]
		public int ACMPJHFMLGP(int BDANDOICAJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA210", Offset = "0x3AA9010", VA = "0x183AAA210")]
		public double KICPNDHDJIC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA170", Offset = "0x3AA8F70", VA = "0x183AAA170")]
		public KKALGKGLKNG FNHDJKPAPHF(long ECACALFBNEG, int OPIEJNLPPJB)
		{
			return default(KKALGKGLKNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NDDNJDNHBMI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct FPKCGAOLMCN<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NDDNJDNHBMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<NDDNJDNHBMI, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private NDDNJDNHBMI <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x36293B0", Offset = "0x36281B0", VA = "0x1836293B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3628000", Offset = "0x3626E00", VA = "0x183628000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey OFBDILANEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly AGDBIEMPPKH<TKey> LJNGGJLINNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly IBJKCJFAAOH LHKCFFJGAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<NDDNJDNHBMI> KKLLJMEPOMJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string HJNNIDEJINH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3DE96D0", Offset = "0x3DE84D0", VA = "0x183DE96D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<NDDNJDNHBMI> OECJPKDDEBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9660", Offset = "0x3DE8460", VA = "0x183DE9660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public KKALGKGLKNG PFIOMJJBHCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9640", Offset = "0x3DE8440", VA = "0x183DE9640")]
			[CompilerGenerated]
			get
			{
				return default(KKALGKGLKNG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE96A0", Offset = "0x3DE84A0", VA = "0x183DE96A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9700", Offset = "0x3DE8500", VA = "0x183DE9700")]
		internal NDDNJDNHBMI(AGDBIEMPPKH<TKey> LJNGGJLINNI, TKey IDGIKKEFDCG, IBJKCJFAAOH LHKCFFJGAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DE92E0", Offset = "0x3DE80E0", VA = "0x183DE92E0")]
		public NDDNJDNHBMI CAJJAIPKFFI(TKey IDGIKKEFDCG, [Optional] IBJKCJFAAOH? DHLOLMLHDPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x230C960", Offset = "0x230B760", VA = "0x18230C960")]
		[AsyncStateMachine(typeof(FPKCGAOLMCN<>))]
		public Task<T> JFCBLKBKOCM<T>(TKey IDGIKKEFDCG, Func<NDDNJDNHBMI, Task<T>> OLKLBJAAOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9440", Offset = "0x3DE8240", VA = "0x183DE9440", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class AMJCJKDCLOL : IEnumerable<(TKey, List<TKey>, KKALGKGLKNG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KKALGKGLKNG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, KKALGKGLKNG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AGDBIEMPPKH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, KKALGKGLKNG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, KKALGKGLKNG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E65770", Offset = "0x1E64570", VA = "0x181E65770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KKALGKGLKNG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x36B03D0", Offset = "0x36AF1D0", VA = "0x1836B03D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E65860", Offset = "0x1E64660", VA = "0x181E65860")]
		[DebuggerHidden]
		public AMJCJKDCLOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3368F90", Offset = "0x3367D90", VA = "0x183368F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x36AFF20", Offset = "0x36AED20", VA = "0x1836AFF20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x36AFED0", Offset = "0x36AECD0", VA = "0x1836AFED0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x36B0380", Offset = "0x36AF180", VA = "0x1836B0380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x36B02C0", Offset = "0x36AF0C0", VA = "0x1836B02C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKALGKGLKNG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x34C1570", Offset = "0x34C0370", VA = "0x1834C1570", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JBCGEOFPLGF : IEnumerable<(TKey, List<TKey>, KKALGKGLKNG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KKALGKGLKNG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, KKALGKGLKNG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NDDNJDNHBMI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NDDNJDNHBMI <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AGDBIEMPPKH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<NDDNJDNHBMI> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, KKALGKGLKNG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, KKALGKGLKNG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E65770", Offset = "0x1E64570", VA = "0x181E65770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KKALGKGLKNG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x39A0C90", Offset = "0x399FA90", VA = "0x1839A0C90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1E65860", Offset = "0x1E64660", VA = "0x181E65860")]
		[DebuggerHidden]
		public JBCGEOFPLGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x39A0CF0", Offset = "0x399FAF0", VA = "0x1839A0CF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x39A0320", Offset = "0x399F120", VA = "0x1839A0320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x39A02C0", Offset = "0x399F0C0", VA = "0x1839A02C0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x39A0AD0", Offset = "0x399F8D0", VA = "0x1839A0AD0")]
		private void PDOLPCEBNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x39A0C40", Offset = "0x399FA40", VA = "0x1839A0C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x39A0B30", Offset = "0x399F930", VA = "0x1839A0B30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKALGKGLKNG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x39A0C10", Offset = "0x399FA10", VA = "0x1839A0C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, KKALGKGLKNG, IBJKCJFAAOH> PPFALNHDGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, KKALGKGLKNG, IBJKCJFAAOH> MMELPFMPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<AGDBIEMPPKH<TKey>, IBJKCJFAAOH> NELJOMJIIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IBJKCJFAAOH LHKCFFJGAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NDDNJDNHBMI MPKAMCAPJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool FHCLJNNFIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int AFNBIFIHMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch NLPHHDDKHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int DPGHHLENKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string JKKLEPJICHM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NDDNJDNHBMI JAHPPNPKDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string HJNNIDEJINH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x78D1A0", Offset = "0x78BFA0", VA = "0x18078D1A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x368D8B0", Offset = "0x368C6B0", VA = "0x18368D8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x368D910", Offset = "0x368C710", VA = "0x18368D910")]
	public AGDBIEMPPKH(TKey EPJMFLANEAD, IBJKCJFAAOH LHKCFFJGAEC, [Optional] int? BFJKFNKJJOK, [Optional][CanBeNull] Stopwatch NLPHHDDKHLO, [Optional] Action<TKey, KKALGKGLKNG, IBJKCJFAAOH> PPFALNHDGHM, [Optional] Action<TKey, KKALGKGLKNG, IBJKCJFAAOH> MMELPFMPKKJ, [Optional] Action<AGDBIEMPPKH<TKey>, IBJKCJFAAOH> NELJOMJIIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x368D640", Offset = "0x368C440", VA = "0x18368D640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x368D7A0", Offset = "0x368C5A0", VA = "0x18368D7A0")]
	[IteratorStateMachine(typeof(AGDBIEMPPKH<>.AMJCJKDCLOL))]
	public IEnumerable<(TKey, List<TKey>, KKALGKGLKNG)> EEAOJKFJEFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x368D6D0", Offset = "0x368C4D0", VA = "0x18368D6D0")]
	[IteratorStateMachine(typeof(AGDBIEMPPKH<>.JBCGEOFPLGF))]
	private IEnumerable<(TKey, List<TKey>, KKALGKGLKNG)> EEAOJKFJEFD(List<TKey> GANCAKMMLGB, NDDNJDNHBMI CFJFHHPOECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x368D830", Offset = "0x368C630", VA = "0x18368D830")]
	private (long, int) GCDDCLIMICD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class OHPEDFOLDGG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OEPFCLAAIJE(AGDBIEMPPKH<TKey> LJNGGJLINNI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected OHPEDFOLDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class LHPFIOJIHKI<TKey> : OHPEDFOLDGG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string MLMIDJJGKNM(TKey IDGIKKEFDCG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A7A0", Offset = "0x3B495A0", VA = "0x183B4A7A0")]
	private static string HPIPBPFKNDI(TKey IDGIKKEFDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A7E0", Offset = "0x3B495E0", VA = "0x183B4A7E0", Slot = "4")]
	public override string OEPFCLAAIJE(AGDBIEMPPKH<TKey> LJNGGJLINNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A8A0", Offset = "0x3B496A0", VA = "0x183B4A8A0")]
	public string OEPFCLAAIJE(AGDBIEMPPKH<TKey> LJNGGJLINNI, [NotNull] MLMIDJJGKNM PCDFGNGHLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NKFFJNPGHJF(AGDBIEMPPKH<TKey> LJNGGJLINNI, [NotNull] MLMIDJJGKNM PCDFGNGHLKK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x36008F0", Offset = "0x35FF6F0", VA = "0x1836008F0")]
	protected LHPFIOJIHKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class IIMOCKIJMHH<TKey> : OHPEDFOLDGG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string FPBIEPBHPFJ(TKey IDGIKKEFDCG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string CKAEOIENDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double NMNNCEEJPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool HCHBDFIDHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int FBGGADFDNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> FPBAIMKLBIH;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3812170", Offset = "0x3810F70", VA = "0x183812170")]
	private static string HPIPBPFKNDI(TKey IDGIKKEFDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3812CE0", Offset = "0x3811AE0", VA = "0x183812CE0")]
	public IIMOCKIJMHH(string CKAEOIENDFH = "F2", double NMNNCEEJPAA = double.MaxValue, bool HCHBDFIDHAE = false, int FBGGADFDNIP = int.MaxValue, [Optional] ISet<string> FPBAIMKLBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3812630", Offset = "0x3811430", VA = "0x183812630", Slot = "4")]
	public override Dictionary<string, string> OEPFCLAAIJE(AGDBIEMPPKH<TKey> LJNGGJLINNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x38123F0", Offset = "0x38111F0", VA = "0x1838123F0")]
	private bool LFGFEJJJBDF(string GCPACPJPAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x38126F0", Offset = "0x38114F0", VA = "0x1838126F0")]
	public Dictionary<string, string> OEPFCLAAIJE(AGDBIEMPPKH<TKey> LJNGGJLINNI, FPBIEPBHPFJ PCDFGNGHLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x38121B0", Offset = "0x3810FB0", VA = "0x1838121B0")]
	private string JEMBMBBIOCJ(StringBuilder OIGGDMCGPIO, List<TKey> NBKGOIHHAII, FPBIEPBHPFJ PCDFGNGHLKK, bool KPCNCHNKJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x38124D0", Offset = "0x38112D0", VA = "0x1838124D0")]
	private static void NFELNKHCFDO(StringBuilder HKBCGEAEPIJ, string GGNGJFIIMMF, bool ACGACKKJCII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NHNOJEEAHJM<TKey> : LHPFIOJIHKI<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MJKKLFECKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MLMIDJJGKNM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static NHNOJEEAHJM<TKey> CEIKCOHBGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] EDCNBJHONCA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5BF0", Offset = "0x3DF49F0", VA = "0x183DF5BF0")]
	private NHNOJEEAHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4C80", Offset = "0x3DF3A80", VA = "0x183DF4C80", Slot = "5")]
	protected override string NKFFJNPGHJF(AGDBIEMPPKH<TKey> LJNGGJLINNI, MLMIDJJGKNM PCDFGNGHLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4B90", Offset = "0x3DF3990", VA = "0x183DF4B90")]
	[CompilerGenerated]
	internal static string GBELIDDADDO(string IIDAFEMLPDP, TKey IDGIKKEFDCG, MJKKLFECKOC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class FEAKIHJKOJJ : AGDBIEMPPKH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NAIDDPNNKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<FEAKIHJKOJJ, IBJKCJFAAOH> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public NAIDDPNNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6930", Offset = "0x5FA5730", VA = "0x185FA6930")]
		internal void BNKHDNHEMCD(AGDBIEMPPKH<string> timer, IBJKCJFAAOH log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4FF0", Offset = "0x5FA3DF0", VA = "0x185FA4FF0")]
	public FEAKIHJKOJJ(IBJKCJFAAOH LHKCFFJGAEC, [Optional] string IIDNBOCFEDI, [Optional] int? BFJKFNKJJOK, [Optional] Stopwatch NLPHHDDKHLO, [Optional] Action<string, KKALGKGLKNG, IBJKCJFAAOH> PPFALNHDGHM, [Optional] Action<string, KKALGKGLKNG, IBJKCJFAAOH> MMELPFMPKKJ, [Optional] Action<FEAKIHJKOJJ, IBJKCJFAAOH> NELJOMJIIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4F30", Offset = "0x5FA3D30", VA = "0x185FA4F30")]
	private static Action<AGDBIEMPPKH<string>, IBJKCJFAAOH> NBLJEOFJLBI(Action<FEAKIHJKOJJ, IBJKCJFAAOH> EAGOMMNFHFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class BFMOBPLNJPB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class IKBKEFNGILG : BFMOBPLNJPB
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static BFMOBPLNJPB CEIKCOHBGGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6140", Offset = "0x5FA4F40", VA = "0x185FA6140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float DLEDPFEPPKO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7370", Offset = "0x1CE6170", VA = "0x181CE7370", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6240", Offset = "0x5FA5040", VA = "0x185FA6240")]
		public IKBKEFNGILG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static BFMOBPLNJPB BGPHALEJJDK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static BFMOBPLNJPB DOPLKALBEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3A40", Offset = "0x5FA2840", VA = "0x185FA3A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float DLEDPFEPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected BFMOBPLNJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FOAKHGMBAIN<T> : GPLMKBKFGHN<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> NEFMEPLGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override FJJBNKADFNG<T> MGKPJCOEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3623A10", Offset = "0x3622810", VA = "0x183623A10")]
	public FOAKHGMBAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "10")]
	protected override void BHBHPNILBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HIGFKOOBDFO<T> : GPLMKBKFGHN<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> NEFMEPLGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override FJJBNKADFNG<T> MGKPJCOEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3753060", Offset = "0x3751E60", VA = "0x183753060")]
	public HIGFKOOBDFO(Exception PNLFFEACIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "10")]
	protected override void BHBHPNILBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OCLJIPMHECD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface INJGOFBOMAK<T> : OCLJIPMHECD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> NEFMEPLGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	FJJBNKADFNG<T> MGKPJCOEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class GPLMKBKFGHN<T> : INJGOFBOMAK<T>, OCLJIPMHECD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FAIKJEPOLAE EBJFJHBCCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool FHCLJNNFIBK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x97E1F0", Offset = "0x97CFF0", VA = "0x18097E1F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> NEFMEPLGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract FJJBNKADFNG<T> MGKPJCOEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x37053E0", Offset = "0x37041E0", VA = "0x1837053E0")]
	public GPLMKBKFGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3705360", Offset = "0x3704160", VA = "0x183705360", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BHBHPNILBJD();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class GFIFAIICPMO<TTask, T> : GPLMKBKFGHN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FPIMHGDHJDN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public FPIMHGDHJDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x304E600", Offset = "0x304D400", VA = "0x18304E600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x304E8D0", Offset = "0x304D6D0", VA = "0x18304E8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GFIFAIICPMO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public FPIMHGDHJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x36285B0", Offset = "0x36273B0", VA = "0x1836285B0")]
		[AsyncStateMachine(typeof(GFIFAIICPMO<, >.FPIMHGDHJDN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> EPANIPKALDP(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> LBLAAGGIDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource ELAGOJJKAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> NEFMEPLGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override FJJBNKADFNG<T> MGKPJCOEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x36DD470", Offset = "0x36DC270", VA = "0x1836DD470")]
	protected GFIFAIICPMO(TTask LBLAAGGIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x36DD280", Offset = "0x36DC080", VA = "0x1836DD280", Slot = "10")]
	protected override void BHBHPNILBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T BNBCNGLFEPC(TTask DBLOCGKKDFM);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void JPKCFIJNBHD();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FDPEOEOEPLL<T> : GPLMKBKFGHN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HPJIADMGLDJ<Task<T>> EIECDPDDJBK;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> NEFMEPLGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x35D6B10", Offset = "0x35D5910", VA = "0x1835D6B10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override FJJBNKADFNG<T> MGKPJCOEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x35E75F0", Offset = "0x35E63F0", VA = "0x1835E75F0")]
	public FDPEOEOEPLL(HPJIADMGLDJ<Task<T>> JBGLBNOADNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x35E75D0", Offset = "0x35E63D0", VA = "0x1835E75D0", Slot = "10")]
	protected override void BHBHPNILBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JPOHKOBDBNL
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6630", Offset = "0x5FA5430", VA = "0x185FA6630")]
	[NotNull]
	public static byte[] FEHIIOGFDPM(this HJKHGLKJOCN NPIBJHIAEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA65C0", Offset = "0x5FA53C0", VA = "0x185FA65C0")]
	[NotNull]
	public static byte[] FEHIIOGFDPM(this HJKHGLKJOCN NPIBJHIAEDP, HashAlgorithmName JDAPLLDPBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6430", Offset = "0x5FA5230", VA = "0x185FA6430")]
	public static bool BMJNKGNIBDL([CanBeNull] this HJKHGLKJOCN NPIBJHIAEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6290", Offset = "0x5FA5090", VA = "0x185FA6290")]
	public static bool BMJNKGNIBDL([CanBeNull] this HJKHGLKJOCN NPIBJHIAEDP, [Out] string NGPMDAJFCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FA66A0", Offset = "0x5FA54A0", VA = "0x185FA66A0")]
	private static bool KLFAKKKAMHB([NotNull] HJKHGLKJOCN NPIBJHIAEDP, [Out][CanBeNull] byte[] LFNEBAJICFL, [Out][CanBeNull] byte[] FCGCFKLKIBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FAEADDJJDDB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3D90", Offset = "0x5FA2B90", VA = "0x185FA3D90")]
	[NotNull]
	public static byte[] FEHIIOGFDPM(this GCCILCGHAMO GAKIBFHLIDD, HashAlgorithmName JDAPLLDPBNI, byte[] GGNAAODODEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GCCILCGHAMO
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NGEJDKKNACK);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HJKHGLKJOCN : GCCILCGHAMO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] FPDAGCEFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] GNAMFPBLEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GGMFOBFKEAA
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly ArrayPool<byte> DCGEMOHNPFH;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static bool KHNKPIFNALI;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FA52E0", Offset = "0x5FA40E0", VA = "0x185FA52E0")]
	public static void APLGMDKCKFB(this IncrementalHash KCMHDNLDIFL, [CanBeNull] GameObject FAIKIGMIEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x25C0440", Offset = "0x25BF240", VA = "0x1825C0440")]
	public static void APLGMDKCKFB<T>(this IncrementalHash KCMHDNLDIFL, [CanBeNull] T HFOAJNFAAPM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x25C0500", Offset = "0x25BF300", VA = "0x1825C0500")]
	public static void DNPNPGKHPAD<T>(this IncrementalHash KCMHDNLDIFL, [CanBeNull] T GAKIBFHLIDD) where T : GCCILCGHAMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x25C0BC0", Offset = "0x25BF9C0", VA = "0x1825C0BC0")]
	public static void PKHCPKOHNMI<T>(this IncrementalHash KCMHDNLDIFL, [CanBeNull] IList<T> NKFKHJIPHNM) where T : GCCILCGHAMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5820", Offset = "0x5FA4620", VA = "0x185FA5820")]
	private static bool HMDPHDJCJBG([CanBeNull] GCCILCGHAMO GAKIBFHLIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5280", Offset = "0x5FA4080", VA = "0x185FA5280")]
	public static void APEADKBBPPK(this IncrementalHash NGEJDKKNACK, [CanBeNull] string NGJJEMECHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA54E0", Offset = "0x5FA42E0", VA = "0x185FA54E0")]
	public static void FCMBLIIBEEA(this IncrementalHash NGEJDKKNACK, long ELOKENMNOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5D20", Offset = "0x5FA4B20", VA = "0x185FA5D20")]
	public static void NMENLDJJOHM(this IncrementalHash NGEJDKKNACK, int MFFGHNHICBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5A20", Offset = "0x5FA4820", VA = "0x185FA5A20")]
	public static void KPEOBIOHACO(this IncrementalHash NGEJDKKNACK, short ONPDELDGJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5710", Offset = "0x5FA4510", VA = "0x185FA5710")]
	public static void HDJAPMHILDM(this IncrementalHash NGEJDKKNACK, byte JGKOOGHIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA58B0", Offset = "0x5FA46B0", VA = "0x185FA58B0")]
	public static void IACOEDDCPPM(this IncrementalHash NGEJDKKNACK, bool LMNGGAAEAGA, bool KFAAEKPFDKA = false, bool EBACPNIDIID = false, bool GBOECEHNAPD = false, bool HGJLJDIKMIK = false, bool LBFLDDFJOJC = false, bool FAHGEHPAEMJ = false, bool GGDIINKINIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x25C0590", Offset = "0x25BF390", VA = "0x1825C0590")]
	public static void LPCGELPMOAG<T>(this IncrementalHash NGEJDKKNACK, T ECHPJMAFKIL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5FA56B0", Offset = "0x5FA44B0", VA = "0x185FA56B0")]
	public static void GOBAPGLOEMC(this IncrementalHash NGEJDKKNACK, float NKJGJCEJEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5480", Offset = "0x5FA4280", VA = "0x185FA5480")]
	public static void ENLOKOJIDCP(this IncrementalHash NGEJDKKNACK, ulong LAIJAPJDIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5420", Offset = "0x5FA4220", VA = "0x185FA5420")]
	public static void CGGGBLDLNAP(this IncrementalHash NGEJDKKNACK, uint KLELGIDLHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5FA53C0", Offset = "0x5FA41C0", VA = "0x185FA53C0")]
	public static void BDAKNDGCBAG(this IncrementalHash NGEJDKKNACK, ushort KLBIJHOFDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5BF0", Offset = "0x5FA49F0", VA = "0x185FA5BF0")]
	public static void NHKMAFCOCEH(this IncrementalHash NGEJDKKNACK, Vector3 KFCNLNNPHON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EFGAKAMGJKE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3D30", Offset = "0x5FA2B30", VA = "0x185FA3D30")]
	public EFGAKAMGJKE(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class EAFHLFJPHNJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal class MLPNBFMFOCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode OJFDNDCDDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TNode GEFCENNBDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DBJLBHMFNJA IFEOINIMKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<DBJLBHMFNJA> JHLEHOOANLE;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MLPNBFMFOCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal struct DBJLBHMFNJA : IComparable<DBJLBHMFNJA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int ACJKHACHDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public TClaimant JNBADFFEPPJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB98AD0", Offset = "0xB978D0", VA = "0x180B98AD0")]
		public DBJLBHMFNJA(int ACJKHACHDDL, TClaimant JNBADFFEPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4F10DF0", Offset = "0x4F0FBF0", VA = "0x184F10DF0")]
		public bool EHDOGFLGOED([In] DBJLBHMFNJA GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4F10DD0", Offset = "0x4F0FBD0", VA = "0x184F10DD0")]
		public bool BAKLPMDIGLE([In] DBJLBHMFNJA GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4F10DE0", Offset = "0x4F0FBE0", VA = "0x184F10DE0", Slot = "4")]
		public int CompareTo(DBJLBHMFNJA GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4F10E50", Offset = "0x4F0FC50", VA = "0x184F10E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum JFFKDJNAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class ODCDFEGHFNL : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public EAFHLFJPHNJ<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x92FFC0", Offset = "0x92EDC0", VA = "0x18092FFC0")]
		[DebuggerHidden]
		public ODCDFEGHFNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EE2F20", Offset = "0x3EE1D20", VA = "0x183EE2F20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EE30E0", Offset = "0x3EE1EE0", VA = "0x183EE30E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3000", Offset = "0x3EE1E00", VA = "0x183EE3000", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x33698C0", Offset = "0x33686C0", VA = "0x1833698C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly EBNEFDLFELK<MLPNBFMFOCE> HJIKHCPNGOL;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly EBNEFDLFELK<List<DBJLBHMFNJA>> NAAGHGBMDGA;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int HAGKCACINHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TClaimant, TNode> IDGLCGNDFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	internal readonly Dictionary<TNode, MLPNBFMFOCE> OLPHEDGOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private JFFKDJNAGOO HFILCPIGNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool DNFKHDPAHCP;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KPPKAFNEKLH(TNode NJDCNMOJCAA);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CCNJKODJIMO(TNode NJDCNMOJCAA, TClaimant IALGIDEGEMD, TClaimant CBDBAKPOIGJ);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3233490", Offset = "0x3232290", VA = "0x183233490")]
	public EAFHLFJPHNJ(JFFKDJNAGOO HFILCPIGNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3231C70", Offset = "0x3230A70", VA = "0x183231C70")]
	public void AHKHEAIEGBN(TNode NJDCNMOJCAA, TNode BLKPHAHLOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x32322D0", Offset = "0x32310D0", VA = "0x1832322D0")]
	public void DFNHIGNLKHC(TClaimant JNBADFFEPPJ, TNode OLKMHLEEJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x32323F0", Offset = "0x32311F0", VA = "0x1832323F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3232890", Offset = "0x3231690", VA = "0x183232890")]
	private void FHMKOMGDNGO(TClaimant JNBADFFEPPJ, TNode EBFPDEJPMGG, TNode OLKMHLEEJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x32326B0", Offset = "0x32314B0", VA = "0x1832326B0")]
	private int EMPHPMCBJJD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3232A40", Offset = "0x3231840", VA = "0x183232A40")]
	private void JBKHIOPKIPN(TClaimant JNBADFFEPPJ, TNode DGHOEPLOHCO, TNode EJDCOKLMKOL, int PJFPODLEIIJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3232150", Offset = "0x3230F50", VA = "0x183232150")]
	private void CAHALEIANMA(DBJLBHMFNJA CCDLGGPPCBG, MLPNBFMFOCE NPMDFMNNIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3231D00", Offset = "0x3230B00", VA = "0x183231D00")]
	private void AIIDMKMJBMD(TClaimant JNBADFFEPPJ, TNode DGHOEPLOHCO, TNode EJDCOKLMKOL, int PJFPODLEIIJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3232930", Offset = "0x3231730", VA = "0x183232930")]
	private void GIFKKFHBDIA(DBJLBHMFNJA CCDLGGPPCBG, TNode NJDCNMOJCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x32325C0", Offset = "0x32313C0", VA = "0x1832325C0")]
	private void EJPPFOEHNJF(DBJLBHMFNJA CCDLGGPPCBG, MLPNBFMFOCE NPMDFMNNIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x32331A0", Offset = "0x3231FA0", VA = "0x1832331A0")]
	private void MIFPPMFGFKK(MLPNBFMFOCE NPMDFMNNIKO, bool NJDOOKHGOIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3232E60", Offset = "0x3231C60", VA = "0x183232E60")]
	private void LIEPANHNONB(MLPNBFMFOCE NPMDFMNNIKO, TNode BLKPHAHLOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3232D80", Offset = "0x3231B80", VA = "0x183232D80")]
	[IteratorStateMachine(typeof(EAFHLFJPHNJ<, >.ODCDFEGHFNL))]
	private IEnumerable<TNode> KJEGGEFIFDJ(TNode DGHOEPLOHCO, TNode EJDCOKLMKOL, bool CAHLLAIOCCK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x32321E0", Offset = "0x3230FE0", VA = "0x1832321E0")]
	private MLPNBFMFOCE CLPFNLEJFLG(TNode NJDCNMOJCAA, TNode GEFCENNBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3231FE0", Offset = "0x3230DE0", VA = "0x183231FE0")]
	private MLPNBFMFOCE BGIELCBEDPJ(TNode NJDCNMOJCAA, TNode GEFCENNBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3232720", Offset = "0x3231520", VA = "0x183232720")]
	private void FEPNKGCJHEJ(MLPNBFMFOCE NPMDFMNNIKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CABGHLGJEPD<T> : IEnumerable<CABGHLGJEPD<T>.NGJOLJOGLJM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct NGJOLJOGLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public T MBDKMNBCLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int HPLKFBKKIBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class PHLGAOOAFFO : IEnumerator<NGJOLJOGLJM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private CABGHLGJEPD<T> MFEKCDHJOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int HPLKFBKKIBG;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x32AB2F0", Offset = "0x32AA0F0", VA = "0x1832AB2F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NGJOLJOGLJM GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x4021550", Offset = "0x4020350", VA = "0x184021550", Slot = "4")]
			get
			{
				return default(NGJOLJOGLJM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4021460", Offset = "0x4020260", VA = "0x184021460")]
		public PHLGAOOAFFO(CABGHLGJEPD<T> MFEKCDHJOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4021360", Offset = "0x4020160", VA = "0x184021360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x32F9A40", Offset = "0x32F8840", VA = "0x1832F9A40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B667C0", Offset = "0x1B655C0", VA = "0x181B667C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct LOKAGFAHILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public bool KFKFDHKNLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public T MBDKMNBCLGF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const int OJCIKDAOJLN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly Dictionary<T, int> MDNNCCPPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private LOKAGFAHILJ[] PNKMBOOAOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int LIEHICEGPBJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int EBFGCCMNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3E0", Offset = "0x7CC1E0", VA = "0x1807CD3E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7CC820", Offset = "0x7CB620", VA = "0x1807CC820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x305E230", Offset = "0x305D030", VA = "0x18305E230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x47F1BC0", Offset = "0x47F09C0", VA = "0x1847F1BC0")]
	public CABGHLGJEPD(int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x47F2070", Offset = "0x47F0E70", VA = "0x1847F2070")]
	public CABGHLGJEPD(NGJOLJOGLJM[] AONMKAFFDAP, bool IFOOCFPCMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x47F15D0", Offset = "0x47F03D0", VA = "0x1847F15D0")]
	public int DICOHJCENAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x47F18B0", Offset = "0x47F06B0", VA = "0x1847F18B0")]
	private int NJPOCKCCKEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x47F1690", Offset = "0x47F0490", VA = "0x1847F1690", Slot = "6")]
	protected virtual uint FEGMMPKGEBJ(uint NGEJDKKNACK, T MBDKMNBCLGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x47F1AF0", Offset = "0x47F08F0", VA = "0x1847F1AF0")]
	public bool PADEMKEJAMH(T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x47F1560", Offset = "0x47F0360", VA = "0x1847F1560")]
	public int DFPMHFBGDPA(T MBDKMNBCLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x47F0E90", Offset = "0x47EFC90", VA = "0x1847F0E90")]
	public T ACJIJOPIHMK(int HPLKFBKKIBG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x47F1250", Offset = "0x47F0050", VA = "0x1847F1250")]
	public bool CJDLFIMGCDM(T MBDKMNBCLGF, bool EADGJFLEHDP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x47F0FF0", Offset = "0x47EFDF0", VA = "0x1847F0FF0")]
	public bool CJDLFIMGCDM(T MBDKMNBCLGF, int HPLKFBKKIBG, bool EADGJFLEHDP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x47F0F50", Offset = "0x47EFD50", VA = "0x1847F0F50")]
	private int CCJNFPDFEAN(int MIMLCMKCBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x47F1B40", Offset = "0x47F0940", VA = "0x1847F1B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x47F1B40", Offset = "0x47F0940", VA = "0x1847F1B40", Slot = "4")]
	private IEnumerator<NGJOLJOGLJM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EBNEFDLFELK<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Stack<T> CFGEJCIMJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<T> MGBKEDFMDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly int IFPIDLLBODK;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3234B50", Offset = "0x3233950", VA = "0x183234B50")]
	public static EBNEFDLFELK<T> IGIDHPJOCIK(int IBODGIFCPFK = 0, int IFPIDLLBODK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3235170", Offset = "0x3233F70", VA = "0x183235170")]
	public EBNEFDLFELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3234FD0", Offset = "0x3233DD0", VA = "0x183234FD0")]
	public EBNEFDLFELK(int IBODGIFCPFK, int IFPIDLLBODK = int.MaxValue, bool LOKPMOKEPPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3234E30", Offset = "0x3233C30", VA = "0x183234E30")]
	public T KILMBPDMCDG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x32349A0", Offset = "0x32337A0", VA = "0x1832349A0")]
	public void ENHCKFGAJIO(T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3234A70", Offset = "0x3233870", VA = "0x183234A70")]
	private void GIGAAMELPNP(T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3234FB0", Offset = "0x3233DB0", VA = "0x183234FB0")]
	private void PJICKKJMFIC(T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3234860", Offset = "0x3233660", VA = "0x183234860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3234C30", Offset = "0x3233A30", VA = "0x183234C30")]
	private void IOHFKLCCNNH(IEnumerable<T> GPKFACOMFHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BJLBKDNDJIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<int, T> CIIBEKGMGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private T KNMDFHHEIEC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T EHDBLMGGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x78DFC0", Offset = "0x78CDC0", VA = "0x18078DFC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x46AC330", Offset = "0x46AB130", VA = "0x1846AC330")]
	public bool PPFIDGJABPB(T MBDKMNBCLGF, int ACJKHACHDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3678B20", Offset = "0x3677920", VA = "0x183678B20")]
	public bool JCEEGHPMMAE(int ACJKHACHDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x46ABED0", Offset = "0x46AACD0", VA = "0x1846ABED0")]
	public T BKGNPJGNELM(int FOLBFFOMPCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x46AC220", Offset = "0x46AB020", VA = "0x1846AC220")]
	private bool NFLKDFBFEFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x46AC0C0", Offset = "0x46AAEC0", VA = "0x1846AC0C0")]
	public bool JPCECNBPLDE(int ACJKHACHDDL, [Out] T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x46AC3B0", Offset = "0x46AB1B0", VA = "0x1846AC3B0")]
	public BJLBKDNDJIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ABEJDLKEINA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	protected struct CFIJAFJDBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T AOJPLLHPPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int MFKBBPBJFJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly List<CFIJAFJDBFO> MLGEHMMCOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private T EMHCCOHEPCE;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x305E230", Offset = "0x305D030", VA = "0x18305E230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x367DBE0", Offset = "0x367C9E0", VA = "0x18367DBE0")]
	public bool PCLOONMEAJB(T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x367D980", Offset = "0x367C780", VA = "0x18367D980")]
	public void EHPBILHDFGD(T MBDKMNBCLGF, int ACJKHACHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x367D830", Offset = "0x367C630", VA = "0x18367D830")]
	public bool CPMMAHJGJAD(T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x367DA20", Offset = "0x367C820", VA = "0x18367DA20")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x367D7B0", Offset = "0x367C5B0", VA = "0x18367D7B0")]
	public T AGLFCOHOEBL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x367DA80", Offset = "0x367C880", VA = "0x18367DA80")]
	private void MDKJLGLAFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x367DD60", Offset = "0x367CB60", VA = "0x18367DD60")]
	public ABEJDLKEINA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6B00", Offset = "0x5FA5900", VA = "0x185FA6B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6DD0", Offset = "0x5FA5BD0", VA = "0x185FA6DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6CE0", Offset = "0x5FA5AE0", VA = "0x185FA6CE0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6A50", Offset = "0x5FA5850", VA = "0x185FA6A50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6D20", Offset = "0x5FA5B20", VA = "0x185FA6D20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5FA6C30", Offset = "0x5FA5A30", VA = "0x185FA6C30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FA69C0", Offset = "0x5FA57C0", VA = "0x185FA69C0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x41E4980", Offset = "0x41E3780", VA = "0x1841E4980", Slot = "4")]
		public virtual T FPKBLGLJNFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FDCMAFIEAKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<byte, AMPMMMOLKLM> DFKHDEAOFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly EBNEFDLFELK<AMPMMMOLKLM> EAMLGOFNPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly bool DJADKIHDEPB;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public AMPMMMOLKLM HMIBJCOFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 EFNCOMIDGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xB119A0", Offset = "0xB107A0", VA = "0x180B119A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xDFFB90", Offset = "0xDFE990", VA = "0x180DFFB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 FBCDEGEGGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xE35A10", Offset = "0xE34810", VA = "0x180E35A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 KPPFNIHHDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5FA44D0", Offset = "0x5FA32D0", VA = "0x185FA44D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x78E200", Offset = "0x78D000", VA = "0x18078E200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int PHFGBLMAOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x795710", Offset = "0x794510", VA = "0x180795710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x795190", Offset = "0x793F90", VA = "0x180795190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4AA0", Offset = "0x5FA38A0", VA = "0x185FA4AA0")]
	public FDCMAFIEAKM(Bounds DAHIEHPMOJE, Vector2[] BFFAFBLIKFK, int KKIHMCOPDPO, byte MIMLCMKCBBJ, float DHMJNKKHCDP = 0f, [Optional] EBNEFDLFELK<AMPMMMOLKLM> EAMLGOFNPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3FD0", Offset = "0x5FA2DD0", VA = "0x185FA3FD0")]
	public AMPMMMOLKLM BBIBNKLELPB(byte HPLKFBKKIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4250", Offset = "0x5FA3050", VA = "0x185FA4250")]
	public void BHLPIPECJEH(Vector3 MHFADBEELBD, float BFCIIPMGPPF, float DNNCPMMGEPN, List<byte> PBIMGLCDJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CC38E0", Offset = "0x5CC26E0", VA = "0x185CC38E0")]
	public void JKLAMCLOOMF(AMPMMMOLKLM.ONPHHIBDJHH OFDBFFACJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4320", Offset = "0x5FA3120", VA = "0x185FA4320")]
	public static int CFKEHFOBJGK(Vector2[] BFFAFBLIKFK, int KKIHMCOPDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FA48A0", Offset = "0x5FA36A0", VA = "0x185FA48A0")]
	private AMPMMMOLKLM POFMMLIAACH(byte HPLKFBKKIBG, AMPMMMOLKLM.BKGPIODLLIC HKFDMCOGLCD, AMPMMMOLKLM GEFCENNBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FA44F0", Offset = "0x5FA32F0", VA = "0x185FA44F0")]
	private void LBOKFNEAPMP(AMPMMMOLKLM GEFCENNBDFI, Vector2[] BFFAFBLIKFK, int KAAGNPLMMNC, int KCNALEPFMDH, int FOKDGFKCKGG, int BMFLCGBHKEC, float DHMJNKKHCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4030", Offset = "0x5FA2E30", VA = "0x185FA4030")]
	private void BCLBPHFLMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4410", Offset = "0x5FA3210", VA = "0x185FA4410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4470", Offset = "0x5FA3270", VA = "0x185FA4470", Slot = "1")]
	~FDCMAFIEAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class AMPMMMOLKLM
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum BKGPIODLLIC
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum ONPHHIBDJHH
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public byte JOMDFJHIGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 GEJDPKODOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 ELGBHPFJHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 EKMIBMDGLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 LHKKGGJBEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public BKGPIODLLIC NAFBEOBEANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public AMPMMMOLKLM KKHLELLCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public List<AMPMMMOLKLM> NEGNNKFPNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public bool OFIJLBMDDKH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3A20", Offset = "0x5FA2820", VA = "0x185FA3A20")]
	public AMPMMMOLKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3810", Offset = "0x5FA2610", VA = "0x185FA3810")]
	public void CFNLJBABIEO(AMPMMMOLKLM FGPIOJPMPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	public void JKLAMCLOOMF(int EHMAKGFKKCL, ONPHHIBDJHH OFDBFFACJDN, int LMOMPGJCGNE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FA35B0", Offset = "0x5FA23B0", VA = "0x185FA35B0")]
	public void BHLPIPECJEH(List<byte> PBIMGLCDJGE, Vector3 MHFADBEELBD, float BFCIIPMGPPF, float DNNCPMMGEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FA39F0", Offset = "0x5FA27F0", VA = "0x185FA39F0")]
	public bool OAGAOHCCNPI(Vector3 LCBHOPGDHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FA39C0", Offset = "0x5FA27C0", VA = "0x185FA39C0")]
	public bool JMIOJCIGGDB(Vector3 LCBHOPGDHPF, float NLEDJMBFNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3930", Offset = "0x5FA2730", VA = "0x185FA3930")]
	public void CGDOOEBPPMG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct HAPANELIFBC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly List<Component> HFLDOAFOIEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly bool FPFBIAMPGFC;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3731530", Offset = "0x3730330", VA = "0x183731530")]
			public HAPANELIFBC(List<Component> HFLDOAFOIEF, bool FPFBIAMPGFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x37313F0", Offset = "0x37301F0", VA = "0x1837313F0")]
			public JFOOFEEBOOF<T> BCGCEOCJJAB()
			{
				return default(JFOOFEEBOOF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3731460", Offset = "0x3730260", VA = "0x183731460", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3731460", Offset = "0x3730260", VA = "0x183731460", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct JFOOFEEBOOF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly List<Component> HFLDOAFOIEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly bool FPFBIAMPGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private int HPLKFBKKIBG;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T GCDIDLPMHMC
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x39B2A30", Offset = "0x39B1830", VA = "0x1839B2A30", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x39B29C0", Offset = "0x39B17C0", VA = "0x1839B29C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x39B2A00", Offset = "0x39B1800", VA = "0x1839B2A00")]
			public JFOOFEEBOOF(List<Component> HFLDOAFOIEF, bool FPFBIAMPGFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x39B2900", Offset = "0x39B1700", VA = "0x1839B2900", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x39B2910", Offset = "0x39B1710", VA = "0x1839B2910", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1D110C0", Offset = "0x1D0FEC0", VA = "0x181D110C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8650", Offset = "0x5FA7450", VA = "0x185FA8650")]
		private void CGDOOEBPPMG(GameObject AAGFGONDEFO, bool OEPPFJFNIGI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8490", Offset = "0x5FA7290", VA = "0x185FA8490")]
		public static void CGDOOEBPPMG(GameObject AAGFGONDEFO, ToolHierarchyCache NKBOFPLFCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x28AF370", Offset = "0x28AE170", VA = "0x1828AF370")]
		public void JHCPHNBPKJM<T>(Action<T> APDAGBKMGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x28AF300", Offset = "0x28AE100", VA = "0x1828AF300")]
		public T AOGJGPJEGAD<T>(bool FPFBIAMPGFC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x28AF590", Offset = "0x28AE390", VA = "0x1828AF590")]
		public HAPANELIFBC<T> LJPMLAFEJCI<T>(bool FPFBIAMPGFC = false) where T : class
		{
			return default(HAPANELIFBC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8140", Offset = "0x5FA6F40", VA = "0x185FA8140")]
		public List<Component> AEFCHBGMPDG(Type HJCFEPLFGPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FA87C0", Offset = "0x5FA75C0", VA = "0x185FA87C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache PCOMFHJKLCD, ToolHierarchyCache EANLPGFBDDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8840", Offset = "0x5FA7640", VA = "0x185FA8840", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FGANJEAKCMA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OGCGOGHFCMJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int IBODGIFCPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int LHEEHBKEPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private List<T> PBMGHICHJGB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x35D6B10", Offset = "0x35D5910", VA = "0x1835D6B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T PAEFCMFOLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0F20", Offset = "0x3EEFD20", VA = "0x183EF0F20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T GCPJMHKAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1420", Offset = "0x3EF0220", VA = "0x183EF1420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T LDNGNIEJICG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1230", Offset = "0x3EF0030", VA = "0x183EF1230")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF14F0", Offset = "0x3EF02F0", VA = "0x183EF14F0")]
	public OGCGOGHFCMJ(int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0FE0", Offset = "0x3EEFDE0", VA = "0x183EF0FE0")]
	public void EHPBILHDFGD(T PEBMANKOIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1380", Offset = "0x3EF0180", VA = "0x183EF1380")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3EF12B0", Offset = "0x3EF00B0", VA = "0x183EF12B0")]
	public void IGCPPFOKNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3EF13C0", Offset = "0x3EF01C0", VA = "0x183EF13C0")]
	public void MHIBGFKKEDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0E60", Offset = "0x3EEFC60", VA = "0x183EF0E60")]
	public void BGGCGHIOJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MCGPGODOFLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct GDNHODJCGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int MFKBBPBJFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public T AOJPLLHPPML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<object, GDNHODJCGEP> CIIBEKGMGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly EqualityComparer<T> DHNPEGHHODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private T KNMDFHHEIEC;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T EHDBLMGGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xF00F80", Offset = "0xEFFD80", VA = "0x180F00F80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D41BA0", Offset = "0x3D409A0", VA = "0x183D41BA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool HMPLFKDJHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D41640", Offset = "0x3D40440", VA = "0x183D41640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object GAPEECDBMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3D43760", Offset = "0x3D42560", VA = "0x183D43760")]
	public bool PPFIDGJABPB(T MBDKMNBCLGF, object CGFEMNMBCOK, int ACJKHACHDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3D416A0", Offset = "0x3D404A0", VA = "0x183D416A0")]
	public bool JCEEGHPMMAE(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3D41920", Offset = "0x3D40720", VA = "0x183D41920")]
	public bool JPCECNBPLDE(object CGFEMNMBCOK, [Out] T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3D41BD0", Offset = "0x3D409D0", VA = "0x183D41BD0")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3D41C00", Offset = "0x3D40A00", VA = "0x183D41C00")]
	private bool NFLKDFBFEFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3D43B60", Offset = "0x3D42960", VA = "0x183D43B60")]
	public MCGPGODOFLA()
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
